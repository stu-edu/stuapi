package edu.stu.oauth.demoapp;

import java.io.IOException;
import java.net.URLEncoder;
import java.util.HashMap;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.MultivaluedMap;

import org.apache.commons.codec.binary.Base64;
import org.codehaus.jackson.jaxrs.JacksonJsonProvider;
import org.codehaus.jackson.map.ObjectMapper;

import com.sun.jersey.api.client.Client;
import com.sun.jersey.api.client.ClientResponse;
import com.sun.jersey.api.client.WebResource.Builder;
import com.sun.jersey.api.client.config.ClientConfig;
import com.sun.jersey.api.client.config.DefaultClientConfig;
import com.sun.jersey.core.util.MultivaluedMapImpl;

public class TokenFilter implements Filter {

	
	private String accessTokenEndPoint ;
	private String appKey;
	private String appSecret;
	private String authorizationURL;
//	private String authorizationURLComplete;
	private String redirectUri;//uri to receive accessToken
	private Client client;
	private final ObjectMapper mapper = new ObjectMapper();
	
	@Override
	public void destroy() {
		// TODO Auto-generated method stub

	}

	private void handleRedirectBack(HttpServletRequest request,  HttpServletResponse resp) throws ServletException, IOException{
		//parse response data
		String code = request.getParameter("code");

	    MultivaluedMap<String, String> formData = new MultivaluedMapImpl();
	    formData.add("grant_type", "authorization_code");
	    formData.add("code", code);
	    formData.add("redirect_uri", this.redirectUri);

	    String auth = "Basic ".concat(new String(Base64.encodeBase64(this.appKey.concat(":")
	            .concat(this.appSecret).getBytes())));
	    Builder builder = client.resource(this.accessTokenEndPoint).header("Authorization", auth)
	            .type(MediaType.APPLICATION_FORM_URLENCODED_TYPE);
//	    OutBoundHeaders headers = getHeadersCopy(builder);
	    
	    ClientResponse clientResponse = builder.post(ClientResponse.class, formData);
	    
	    String json = clientResponse.getEntity(String.class);//IOUtils.toString(clientResponse.getEntityInputStream());
	    System.err.println(json);
	    HashMap map = mapper.readValue(json, HashMap.class);
		//save access token
		request.getSession().setAttribute("accessToken", map.get("access_token"));
		
		//redirect to display page
		resp.sendRedirect(request.getServletContext().getContextPath()+"/test/profile/view");
	}
	
	
	@Override
	public void doFilter(ServletRequest arg0, ServletResponse arg1,
			FilterChain arg2) throws IOException, ServletException {
		HttpServletRequest req=(HttpServletRequest)arg0;
		HttpServletResponse resp=(HttpServletResponse)arg1;
		System.err.println(req.getRequestURI());
		if(req.getRequestURI().endsWith("/redirect")){
			handleRedirectBack(req,resp);
			return;
		}
		
		HttpSession session=req.getSession();
		if(session.getAttribute("accessToken")==null){
			String to=String.format(
					authorizationURL.concat("?response_type=%s&client_id=%s&redirect_uri=%s&state=%s"), 
					"code", appKey,redirectUri,
					URLEncoder.encode(req.getRequestURL().toString(),"UTF-8"));
			resp.sendRedirect(to);			
		}
		else{
			arg2.doFilter(arg0, arg1);
		}
	}

	@Override
	public void init(FilterConfig arg0) throws ServletException {
		this.appKey=arg0.getInitParameter("appKey");
		this.appSecret=arg0.getInitParameter("appSecret");
		this.authorizationURL=arg0.getInitParameter("authorizationURL");
		this.accessTokenEndPoint=arg0.getInitParameter("accessTokenEndPoint");
		this.redirectUri=arg0.getInitParameter("redirectUri");
		 ClientConfig config = new DefaultClientConfig();
		    config.getClasses().add(JacksonJsonProvider.class);
		    this.client = Client.create(config);
	}

}
