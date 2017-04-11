using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Web
{
    public class ProfilePicHub : Hub
    {
        private readonly ProfilePicBroadcaster _profilePicture;

        public ProfilePicHub(ProfilePicBroadcaster profilePicture)
        {
            _profilePicture = profilePicture;
        }

    }
}