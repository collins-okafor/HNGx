using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string slack_name, string track)
        {
            var userDetail = new Models.UserDetail();
            userDetail.Slack_name = slack_name;
            userDetail.Current_day = DateTime.Now.ToString("dddd");
            userDetail.Utc_time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            userDetail.Track = track;
            userDetail.Github_file_url = "https://github.com/collins-okafor/HNGx/blob/main/api/Controllers/UserController.cs";
            userDetail.Github_repo_url = "https://github.com/collins-okafor/HNGx";
            userDetail.Status_code = 200;
            return Ok(userDetail);
        }
        
    }
}