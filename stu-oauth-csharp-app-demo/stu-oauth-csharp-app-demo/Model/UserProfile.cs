using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stu_oauth_csharp_app_demo.Model
{
    [Serializable]
    public class UserProfile
    {
        /// <summary>
        /// 用户唯一标识UUID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用户登录帐号/校园帐号
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// 用户全名
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// 用户英文名
        /// </summary>
        public string englishName { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string logoUrl { get; set; }

        /// <summary>
        /// 用户个人信息页封面
        /// </summary>
        public string coverImage { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        public string studentId { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string teacherId { get; set; }
         
    }
}