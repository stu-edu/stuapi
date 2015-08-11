using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using stu_oauth_csharp_app_demo.Model;
using stu_oauth_csharp_app_demo.Tool;
using System.Web.SessionState;


namespace stu_oauth_csharp_app_demo
{
    /// <summary>
    /// DataService 的摘要说明
    /// </summary>
    /// <summary>
    /// DataService 的摘要说明
    /// </summary>
    public class DataService : IHttpHandler, IRequiresSessionState
    {
        private string realm = null;
        private string apiServer = System.Configuration.ConfigurationSettings.AppSettings["ApiServer"].ToString();

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            string apiUrl = string.Empty;

            String profile = string.Empty;
            String courseInfo = string.Empty;
            String courseMember = string.Empty;
            String courseActivities = string.Empty;
            String kechenbiao = string.Empty;
            String chenjibiao = string.Empty;

            String classId = "";
            String filter = "";
            String teacherId = "";
            String studentId = "";

            String action = "";
            String accessToken = "";
            action = context.Request["action"];
            accessToken = context.Session["AccessToken"].ToString();

            switch (action)
            {
                case "getProfile":
                    apiUrl = apiServer + "/profile/self";
                    profile = ProcessRequest(apiUrl, "", "", accessToken);
                    UserProfile userProfile = new UserProfile();
                    userProfile = JsonConvert.DeserializeObject<UserProfile>(profile);

                    context.Response.Write(profile);
                    break;
                case "getCourseInfo":
                    apiUrl = apiServer + "/courses/self";
                    courseInfo = ProcessRequest(apiUrl, "", "", accessToken);
                    List<CourseInfo> courseList = JsonConvert.DeserializeObject<List<CourseInfo>>(courseInfo);
                    context.Response.Write(courseInfo);
                    break;
                case "getCourseMember":
                    classId = context.Request["classId"].ToString();
                    apiUrl = apiServer + "/courses/" + classId + "/members";
                    courseMember = ProcessRequest(apiUrl, "", "", accessToken);

                    break;
                case "getCourseActivities":
                    classId = context.Request["classId"].ToString();
                    filter = context.Request["filter"].ToString();
                    apiUrl = apiServer + "/courses/" + classId + "/activities/" + filter;
                    courseActivities = ProcessRequest(apiUrl, "", "", accessToken);
                    context.Response.Write(courseActivities);
                    break;
                case "getKechengbiao":
                    if (context.Request["teacherId"] != null)
                    {
                        teacherId = context.Request["teacherId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/kechengbiao/" + teacherId + "/20131";
                    }
                    if (context.Request["studentId"] != null)
                    {
                        studentId = context.Request["studentId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/kechengbiao/" + studentId + "/20131";
                    }
                    kechenbiao = ProcessRequest(apiUrl, "", "text/xml", accessToken);
                    DataTable kechenbiaoDt = new DataTable();
                    kechenbiaoDt = getKechengbiao(kechenbiao);
                    string json = string.Empty;
                    json = JsonConvert.SerializeObject(kechenbiaoDt);
                    context.Response.Write(json);
                    break;
                case "getChengjibiao":
                    if (context.Request["studentId"] != null)
                    {
                        studentId = context.Request["studentId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/chengjibiao/" + studentId + "";
                    }
                    chenjibiao = ProcessRequest(apiUrl, "", "text/xml", accessToken);

                    DataTable chenjibiaoDt = new DataTable();
                    chenjibiaoDt = getChengjibiao(chenjibiao);
                    json = JsonConvert.SerializeObject(chenjibiaoDt);
                    context.Response.Write(json);
                    break;
                case "getClassChengjibiao":
                    classId = context.Request["classId"].ToString();
                    apiUrl = apiServer + "/xuefenzhi/chengjibiao/class/" + classId + "";
                    chenjibiao = ProcessRequest(apiUrl, "", "text/xml", accessToken);
                    DataTable classChenjibiaoDt = new DataTable();
                    classChenjibiaoDt = getClassChengjibiao(chenjibiao);
                    json = JsonConvert.SerializeObject(classChenjibiaoDt);
                    context.Response.Write(json);
                    break;
                default:

                    break;
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }



        public string ProcessRequest(string url, string postDataStr, string contentType, string accessToken)
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
            if (contentType == "")
            {
                request.Accept = "application/json";
            }
            else
            {
                request.Accept = contentType;
            }

            request.Headers["Authorization"] = "bearer " + accessToken;
            request.KeepAlive = true;
            //上面的http头看情况而定，但是下面俩必须加  
            if (contentType == "")
            {
                request.ContentType = "application/json";
            }
            else
            {
                request.Accept = contentType;
            }

            request.Method = "GET";
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(responseStream, System.Text.Encoding.UTF8);
            string retString = readStream.ReadToEnd().ToString();
            readStream.Close();

            return retString;
        }

        protected static DataTable GetDataTableByXml(string xmlData)
        {
            DataTable ds = getKechengbiao(xmlData);
            return ds;
        }

        public static DataTable getKechengbiao(string info)
        {
            DataTable dt = new DataTable();
            string result = string.Empty;
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader(info, XmlNodeType.Document, null);

            //开课班号
            dt.Columns.Add("kkb_key", typeof(string));
            //课程名
            dt.Columns.Add("kc_name", typeof(string));
            //上课时间
            dt.Columns.Add("sj_name", typeof(string));
            //上课地点
            dt.Columns.Add("ks_name", typeof(string));
            //授课教师
            dt.Columns.Add("js_name", typeof(string));

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)//判断节点类型为Element  
                {
                    if (reader.Name == "Table")
                    {
                        String childNode = "<dr>" + reader.ReadInnerXml() + "</dr>";
                        XmlTextReader readerChild = new XmlTextReader(childNode, XmlNodeType.Document, null);
                        DataRow dr = dt.NewRow();
                        while (readerChild.Read())
                        {
                            if (readerChild.Name == "kkb_key")
                                dr["kkb_key"] = readerChild.ReadString();

                            if (readerChild.Name == "kc_name")
                                dr["kc_name"] = readerChild.ReadString();

                            if (readerChild.Name == "sj_name")
                                dr["sj_name"] = readerChild.ReadString();

                            if (readerChild.Name == "ks_name")
                                dr["ks_name"] = readerChild.ReadString();

                            if (readerChild.Name == "js_name")
                                dr["js_name"] = readerChild.ReadString();
                        }


                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }


        public static DataTable getChengjibiao(string info)
        {
            DataTable dt = new DataTable();
            string result = string.Empty;
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader(info, XmlNodeType.Document, null);

            //学期
            dt.Columns.Add("xnxq_name", typeof(string));
            //开课班号
            dt.Columns.Add("kkb_key", typeof(string));
            //课程名
            dt.Columns.Add("kc_name", typeof(string));
            //学分
            dt.Columns.Add("xf_no", typeof(string));
            //成绩
            dt.Columns.Add("cj_name", typeof(string));
            //授课教师
            dt.Columns.Add("js_name", typeof(string));

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)//判断节点类型为Element  
                {
                    if (reader.Name == "Table")
                    {
                        String childNode = "<dr>" + reader.ReadInnerXml() + "</dr>";
                        XmlTextReader readerChild = new XmlTextReader(childNode, XmlNodeType.Document, null);
                        DataRow dr = dt.NewRow();
                        while (readerChild.Read())
                        {
                            if (readerChild.Name == "xnxq_name")
                                dr["xnxq_name"] = readerChild.ReadString();

                            if (readerChild.Name == "kkb_key")
                                dr["kkb_key"] = readerChild.ReadString();

                            if (readerChild.Name == "kc_name")
                                dr["kc_name"] = readerChild.ReadString();

                            if (readerChild.Name == "xf_no")
                                dr["xf_no"] = readerChild.ReadString();

                            if (readerChild.Name == "cj_name")
                                dr["cj_name"] = readerChild.ReadString();

                            if (readerChild.Name == "js_name")
                                dr["js_name"] = readerChild.ReadString();
                        }


                        dt.Rows.Add(dr);
                    }
                }
            }

            return dt;
        }

        public static DataTable getClassChengjibiao(string info)
        {
            DataTable dt = new DataTable();
            string result = string.Empty;
            XmlDocument doc = new XmlDocument();
            XmlTextReader reader = new XmlTextReader(info, XmlNodeType.Document, null);

            //学号
            dt.Columns.Add("xs_key", typeof(string));
            //学生姓名
            dt.Columns.Add("xs_name", typeof(string));
            //学分
            dt.Columns.Add("xf_no", typeof(string));
            //成绩
            dt.Columns.Add("cj_name", typeof(string));
            //成绩码
            dt.Columns.Add("cj_no", typeof(string));

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)//判断节点类型为Element  
                {
                    if (reader.Name == "Table")
                    {
                        String childNode = "<dr>" + reader.ReadInnerXml() + "</dr>";
                        XmlTextReader readerChild = new XmlTextReader(childNode, XmlNodeType.Document, null);
                        DataRow dr = dt.NewRow();
                        while (readerChild.Read())
                        {
                            if (readerChild.Name == "xs_key")
                                dr["xs_key"] = readerChild.ReadString();

                            if (readerChild.Name == "xs_name")
                                dr["xs_name"] = readerChild.ReadString();

                            if (readerChild.Name == "xf_no")
                                dr["xf_no"] = readerChild.ReadString();

                            if (readerChild.Name == "cj_name")
                                dr["cj_name"] = readerChild.ReadString();

                            if (readerChild.Name == "cj_no")
                                dr["cj_no"] = readerChild.ReadString();
                        }


                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }
    }
}