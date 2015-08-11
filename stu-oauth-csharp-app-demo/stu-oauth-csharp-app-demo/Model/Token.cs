using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace stu_oauth_csharp_app_demo.Model
{

    [Serializable]
    public class Token
    {
        public string scope { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }
}