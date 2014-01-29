using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRFlash.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void BroadcastMessage(string fromUser, string message)
        {
            Clients.All.writeMessage(fromUser, message);
        }
    }
}