using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class UserDetail
    {
        public string? Slack_name { get; set; }
        public string? Current_day { get; set; }
        public DateTime Utc_time { get; set; }
        public string? Track { get; set; }
        public string? Github_file_url { get; set; }
        public string? Github_repo_url { get; set; }
        public int? Status_code { get; set; }
    }
}