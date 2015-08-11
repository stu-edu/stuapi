using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stu_oauth_csharp_app_demo.Model
{
    [Serializable]
    public class CourseActivity
    {
        /// <summary>
        /// 记录唯一标识UUID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        public Int32 createdAt { get; set; }

        /// <summary>
        /// 课程Id
        /// </summary>
        public string courseId { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        public string courseName { get; set; }

        /// <summary>
        /// 主题Id
        /// </summary>
        public int sectionId { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        public string sectionName { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        public int activityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string activityTitle { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        public string activityCategory { get; set; }


        /// <summary>
        /// 活动类型图标
        /// </summary>
        public string activityCategoryLogo { get; set; }


        /// <summary>
        /// 活动描述
        /// </summary>
        public string activityDescription { get; set; }

        /// <summary>
        /// 活动URL
        /// </summary>
        public string activityUrl { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Int32 additionalStartDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public Int32 additionalEndDate { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public Int32 additionalDueDate { get; set; }

    }
}