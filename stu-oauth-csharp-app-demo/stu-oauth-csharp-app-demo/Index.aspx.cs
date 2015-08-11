using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Xml;
using Newtonsoft.Json;
using stu_oauth_csharp_app_demo.Model;
using stu_oauth_csharp_app_demo.Tool;
using System.Data;

namespace stu_oauth_csharp_app_demo
{
    public partial class Index : System.Web.UI.Page
    {
        private string realm = null;
        private string apiServer = System.Configuration.ConfigurationSettings.AppSettings["ApiServer"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            realm = Request.Url.Scheme + "://" + Request.Url.DnsSafeHost + Request.ApplicationPath;
            string apiUrl = string.Empty;

            string action = Request["action"].ToString();
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
            switch (action)
            {
                case "getProfile":
                    apiUrl = apiServer + "/profile/self";
                    profile = ProcessRequest(apiUrl, "", "");
                    UserProfile userProfile = new UserProfile();
                    userProfile = JsonConvert.DeserializeObject<UserProfile>(profile);
                    this.lb_info.Text = userProfile.fullName + "|" + userProfile.teacherId + userProfile.studentId + "|" + userProfile.username;
                    break;
                case "getCourseInfo":
                    apiUrl = apiServer + "/courses/self";
                    courseInfo = ProcessRequest(apiUrl, "", "");
                    List<CourseInfo> courseList = JsonConvert.DeserializeObject<List<CourseInfo>>(courseInfo);
                    String courses = string.Empty;
                    dl_courses.DataSource = courseList;
                    dl_courses.DataBind();
                    break;
                case "getCourseMember":
                    classId = Request["classId"].ToString();
                    apiUrl = apiServer + "/courses/" + classId + "/members";
                    courseMember = ProcessRequest(apiUrl, "", "");
                    List<CourseMember> courseMemberList = JsonConvert.DeserializeObject<List<CourseMember>>(courseMember);
                    this.lb_info.Text = courseMemberList[0].studentId.ToString();
                    break;
                case "getCourseActivities":
                    classId = Request["classId"].ToString();
                    filter = Request["filter"].ToString();
                    apiUrl = apiServer + "/courses/" + classId + "/activities/" + filter;
                    courseActivities = ProcessRequest(apiUrl, "", "");
                    this.lb_info.Text = courseActivities;
                    break;
                case "getKechengbiao":
                    if (Request["teacherId"] != null)
                    {
                        teacherId = Request["teacherId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/kechengbiao/" + teacherId + "/20132";
                    }
                    if (Request["studentId"] != null)
                    {
                        studentId = Request["studentId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/kechengbiao/" + studentId + "/20132";
                    }
                    kechenbiao = ProcessRequest(apiUrl, "", "text/xml");
                    DataTable kechebiao = GetDataTableByXml(kechenbiao);
                    this.lb_info.Text = kechenbiao;
                    break;
                case "getChengjibiao":
                    if (Request["studentId"] != null)
                    {
                        studentId = Request["studentId"].ToString();
                        apiUrl = apiServer + "/xuefenzhi/chengjibiao/" + studentId + "";
                    }
                    chenjibiao = ProcessRequest(apiUrl, "", "text/xml");
                    this.lb_info.Text = chenjibiao;
                    break;
                default:
                    break;
            }

        }

        public string ProcessRequest(string url, string postDataStr, string contentType)
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

            request.Headers["Authorization"] = "bearer " + Session["AccessToken"].ToString();
            request.KeepAlive = true;
            //上面的http头看情况而定，但是下面俩必须加  
            request.ContentType = "application/json";
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
    }
}