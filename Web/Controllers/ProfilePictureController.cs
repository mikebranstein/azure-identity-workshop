using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class ProfilePictureController : ApiController
    {
        [HttpPost]
        public void Post([FromBody] string profilePicUrl)
        {
            ProfilePicBroadcaster.Instance.BroadcastUpdatedProfilePic(profilePicUrl);
        }
    }
}
