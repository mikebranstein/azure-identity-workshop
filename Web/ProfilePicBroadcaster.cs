using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web
{
    /// <summary>
    ///  FROM https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-server-broadcast-with-signalr
    /// </summary>
    public class ProfilePicBroadcaster
    {
        // Singleton instance
        private readonly static Lazy<ProfilePicBroadcaster> _instance = new Lazy<ProfilePicBroadcaster>(() => new ProfilePicBroadcaster(GlobalHost.ConnectionManager.GetHubContext<ProfilePicHub>().Clients));

        private ProfilePicBroadcaster(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;
        }

        public static ProfilePicBroadcaster Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }

        public void BroadcastUpdatedProfilePic(string profilePicUrl)
        {
            Clients.All.profilePicUpdated(profilePicUrl);
        }
    }
}