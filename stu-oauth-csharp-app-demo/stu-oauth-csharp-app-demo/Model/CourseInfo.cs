using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stu_oauth_csharp_app_demo.Model
{
    [Serializable]
    public class CourseInfo
    {
        /// <summary>
        /// 记录唯一标识UUID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// 开课班号
        /// </summary>
        public string classId { get; set; }

        /// <summary>
        /// 用户在课程中的角色
        /// </summary>
        public string role { get; set; }

        /// <summary>
        /// moodle课程Id
        /// </summary>
        public string moodleCourseId { get; set; }

        /// <summary>
        /// 课程链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 学年
        /// </summary>
        public int attendanceYear { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public int attendanceSemester { get; set; }

    }
}