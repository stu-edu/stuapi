using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using stu_oauth_csharp_app_demo.Model;

namespace stu_oauth_csharp_app_demo
{
    public partial class _Default : System.Web.UI.Page
    {
        private string realm = null;
        private string provider;

        protected void Page_Load(object sender, EventArgs e)
        {
            realm = Request.Url.Scheme + "://" + Request.Url.DnsSafeHost + Request.ApplicationPath;

            if (Session["AccessToken"] != null)
            {

            }
            else
            {
                if (Request.Params["code"] == null)
                {
                    MakeRequestForToken();
                }
                else
                {
                    string authorizeTokenUrl = null;
                    authorizeTokenUrl = System.Configuration.ConfigurationSettings.AppSettings["OAuthServer"].ToString() + "/token";
                    string postString = "grant_type=authorization_code&code=" + Request.Params["code"].ToString() + "&redirect_uri=" + "http://demo.stu.edu.cn/oauthdemo/default.aspx";
                    ProcessRequest(authorizeTokenUrl, postString);

                }
            }
            this.Response.Redirect("Mobile/index.html");


        }



        private void MakeRequestForToken()
        {
            string consumerKey = null;
            string consumerSecret = null;
            string requestTokenEndpoint = null;
            string requestTokenCallback = null;
            string authorizeTokenUrl = null;

            consumerKey = System.Configuration.ConfigurationSettings.AppSettings["ClientAppID"].ToString();
            consumerSecret = System.Configuration.ConfigurationSettings.AppSettings["ClientAppSecret"].ToString();
            requestTokenCallback = System.Configuration.ConfigurationSettings.AppSettings["ReturnUrl"].ToString();
            requestTokenEndpoint = System.Configuration.ConfigurationSettings.AppSettings["OAuthServer"].ToString() + "/authorize?response_type=code&client_id=" + consumerKey + "&redirect_uri=" + requestTokenCallback + "&state=login";
            authorizeTokenUrl = System.Configuration.ConfigurationSettings.AppSettings["OAuthServer"].ToString() + "/token";

            if (String.IsNullOrEmpty(consumerKey) || String.IsNullOrEmpty(consumerSecret))
                throw new ArgumentException("Please set up your consumer key and consumer secret for the selected provider", "consumerKey or consumerSecret");

            // Step 1: Make the call to request a token
            Response.Redirect(requestTokenEndpoint);


        }


        public string ProcessRequest(string url, string postDataStr)
        {
            string consumerKey = null;
            string consumerSecret = null;


            consumerKey = System.Configuration.ConfigurationSettings.AppSettings["ClientAppID"].ToString();
            consumerSecret = System.Configuration.ConfigurationSettings.AppSettings["ClientAppSecret"].ToString();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            CookieContainer cookie = request.CookieContainer;//如果用不到Cookie，删去即可  
            //以下是发送的http头，随便加，其中referer挺重要的，有些网站会根据这个来反盗链  
            request.Referer = realm;
            request.Accept = "application/json";

            string authorization = Convert.ToBase64String(Encoding.UTF8.GetBytes((consumerKey + ":" + consumerSecret)));
            request.Headers["Authorization"] = "Basic " + authorization;
            request.KeepAlive = true;
            //上面的http头看情况而定，但是下面俩必须加  
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";



            Encoding encoding = Encoding.UTF8;//根据网站的编码自定义  
            byte[] postData = Encoding.UTF8.GetBytes(postDataStr);//postDataStr即为发送的数据，格式还是和上次说的一样  
            request.ContentLength = postData.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postData, 0, postData.Length);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            //如果http头中接受gzip的话，这里就要判断是否为有压缩，有的话，直接解压缩即可  
            if (response.Headers["Content-Encoding"] != null && response.Headers["Content-Encoding"].ToLower().Contains("gzip"))
            {
                // responseStream = new GZipStream(responseStream, CompressionMode.Decompress);  
            }

            StreamReader streamReader = new StreamReader(responseStream, encoding);
            string retString = streamReader.ReadToEnd();

            Token token = (Token)JsonConvert.DeserializeObject(retString, typeof(Token));
            PersistAccessToken(token.access_token.ToString());
            streamReader.Close();
            responseStream.Close();

            return retString;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        void PersistRequestToken(string requestToken)
        {
            if (Session["RequestToken"] == null)
            {
                Session.Add("RequestToken", requestToken);
            }
            else
            {
                Session["RequestToken"] = requestToken;
            }
        }

        void PersistAccessToken(string accessToken)
        {
            if (Session["AccessToken"] == null)
            {
                Session.Add("AccessToken", accessToken);
            }
            else
            {
                Session["AccessToken"] = accessToken;
            }
        }

        string GetRequesttoken()
        {
            string requestToken = Session["RequestToken"].ToString();
            Session.Remove("RequestToken");
            return requestToken;
        }

        string GetRouteableUrlFromRelativeUrl(string relativeUrl)
        {
            var url = HttpContext.Current.Request.Url;
            return url.Scheme + "://" + url.Host + VirtualPathUtility.ToAbsolute("~/" + relativeUrl);
        }


    }
}
