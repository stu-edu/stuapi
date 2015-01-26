package edu.stu.oauth.demoapp;

import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.ws.rs.core.MediaType;

import org.apache.commons.io.IOUtils;
import org.codehaus.jackson.jaxrs.JacksonJsonProvider;
import org.codehaus.jackson.map.ObjectMapper;

import com.sun.jersey.api.client.Client;
import com.sun.jersey.api.client.ClientResponse;
import com.sun.jersey.api.client.WebResource.Builder;
import com.sun.jersey.api.client.config.ClientConfig;
import com.sun.jersey.api.client.config.DefaultClientConfig;

public class ProfileServlet extends HttpServlet {
	
	private String api_profile="/services/api/profile/self";
	private String api_cheng_ji_biao="/services/api/xuefenzhi/chengjibiao";
	private String api_ke_cheng_biao="/services/api/xuefenzhi/kechengbiao";
	
	private String resourceServer;
	private Client client;
	private static final ObjectMapper mapper = new ObjectMapper();

	@Override
	public void init() throws ServletException{
		this.resourceServer=this.getServletConfig().getInitParameter("resourceServer");		
	    ClientConfig config = new DefaultClientConfig();
	    config.getClasses().add(JacksonJsonProvider.class);
	    this.client = Client.create(config);
	}
	

	
	protected void doGet( HttpServletRequest req,  HttpServletResponse resp)
			throws ServletException, IOException{
		String accessToken=(String)req.getSession().getAttribute("accessToken");
		if(req.getRequestURI().equals("/irs/answer"))
		{
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			
			Builder builder = client.resource("http://apitest.stu.edu.cn/services/api/question/answer")
			            .header("Authorization", "bearer ".concat(accessToken))
			            .type(MediaType.APPLICATION_JSON).accept(MediaType.APPLICATION_JSON);
	//		OutBoundHeaders headers = getHeadersCopy(builder);
			ClientResponse clientResponse = builder.post(ClientResponse.class);
			String json = IOUtils.toString(clientResponse.getEntityInputStream());
			System.err.println(json);
			//HashMap map = mapper.readValue(json, HashMap.class);
			req.setAttribute("json", json);
			req.getRequestDispatcher("/json.jsp").forward(req, resp);
		}
		else if(req.getRequestURI().endsWith("/test/profile/view")){
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			
			Builder builder = client.resource(this.resourceServer+this.api_profile)
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.APPLICATION_JSON_TYPE);

	//		OutBoundHeaders headers = getHeadersCopy(builder);
			ClientResponse clientResponse = builder.get(ClientResponse.class);
			if(clientResponse.getStatus()!=200)
			{
				resp.sendError(clientResponse.getStatus());
			}
			else{
				String json = IOUtils.toString(clientResponse.getEntityInputStream());
				System.err.println(json);
				HashMap map = mapper.readValue(json, HashMap.class);
				req.getSession().setAttribute("user", map);
				req.setAttribute("profile", json);
				req.getRequestDispatcher("/profile.jsp").forward(req, resp);
			}
		}
		else if(req.getRequestURI().endsWith("/test/chengjibiao")){
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			Map user=(Map)req.getSession().getAttribute("user");
			Builder builder = client.resource(this.resourceServer+this.api_cheng_ji_biao+"/"+user.get("studentId"))
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.TEXT_XML_TYPE);
			ClientResponse clientResponse = builder.get(ClientResponse.class);
			String xml = IOUtils.toString(clientResponse.getEntityInputStream());
			System.err.println(xml);
			req.setAttribute("xml", xml);
			req.getRequestDispatcher("/xml.jsp").forward(req, resp);
		}
		else if(req.getRequestURI().endsWith("/test/kechengbiao")){
			Map user=(Map)req.getSession().getAttribute("user");
			String category=(String)user.get("category");
			boolean isTeacher="faculty".equals(category);
			Builder builder = client.resource(this.resourceServer+this.api_ke_cheng_biao+"/"+(isTeacher?user.get("teacherId"):user.get("studentId"))+"/20131")
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.TEXT_XML_TYPE);
			ClientResponse clientResponse = builder.get(ClientResponse.class);
			String xml = IOUtils.toString(clientResponse.getEntityInputStream());
			req.setAttribute("xml", xml);
			req.getRequestDispatcher("/xml.jsp").forward(req, resp);
		}
		
		else if(req.getRequestURI().endsWith("/test/course/members")){
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			
			String url="/services/api/courses/"+req.getParameter("classId")+"/members";
			
			Builder builder = client.resource(this.resourceServer+url)
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.APPLICATION_JSON_TYPE);

			ClientResponse clientResponse = builder.get(ClientResponse.class);
			if(clientResponse.getStatus()!=200)
			{
				resp.sendError(clientResponse.getStatus());
			}
			else{
				String json = IOUtils.toString(clientResponse.getEntityInputStream());
				System.err.println(json);
				req.setAttribute("json", json);
				req.getRequestDispatcher("/json.jsp").forward(req, resp);
			}
		}
		
		else if(req.getRequestURI().endsWith("/test/courses")){
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			
			String url="/services/api/courses/self";
			
			Builder builder = client.resource(this.resourceServer+url)
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.APPLICATION_JSON_TYPE);

			ClientResponse clientResponse = builder.get(ClientResponse.class);
			if(clientResponse.getStatus()!=200)
			{
				resp.sendError(clientResponse.getStatus());
			}
			else{
				String json = IOUtils.toString(clientResponse.getEntityInputStream());
				System.err.println(json);
				req.setAttribute("json", json);
				req.getRequestDispatcher("/json.jsp").forward(req, resp);
			}
		}
		else if(req.getRequestURI().endsWith("/test/course/activities")){
			//已经有token, 则向provider 请求api，得到数据后再forward到页面
			
			String url="/services/api/courses/"+req.getParameter("classId")+"/activities/"+req.getParameter("filter");
			
			Builder builder = client.resource(this.resourceServer+url)
			            .header("Authorization", "bearer ".concat(accessToken)).accept(MediaType.APPLICATION_JSON_TYPE);

			ClientResponse clientResponse = builder.get(ClientResponse.class);
			if(clientResponse.getStatus()!=200)
			{
				resp.sendError(clientResponse.getStatus());
			}
			else{
				String json = IOUtils.toString(clientResponse.getEntityInputStream());
				System.err.println(json);
				req.setAttribute("json", json);
				req.getRequestDispatcher("/json.jsp").forward(req, resp);
			}
		}
	}
	

	
	  

}
