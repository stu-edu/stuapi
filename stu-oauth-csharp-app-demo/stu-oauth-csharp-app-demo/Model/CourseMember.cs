using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stu_oauth_csharp_app_demo.Model
{
    [Serializable]
    public class CourseMember
    {
        /// <summary>
        /// 记录唯一标识UUID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string studentId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        public string englishName { get; set; }

        /// <summary>
        /// 学院
        /// </summary>
        public string college { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string major { get; set; }

        /// <summary>
        /// 年级
        /// </summary>
        public string attendanceYear { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public string role { get; set; }

    }
}