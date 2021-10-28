using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRTC_Video.Hubs
{
    public class ConnectionHub: Hub
    {
        public async Task CreateRoom(string Room)
        {
            await Clients.All.SendAsync("showroom", Room);
        }

         public Task Joinroom(string Roomid)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, Roomid);
        }
         public override async Task OnDisconnectedAsync(Exception ex)
         {
           await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
           await base.OnDisconnectedAsync(ex);
         }

        public async Task Join(string Roomid, string id)
        {
            await Clients.OthersInGroup(Roomid).SendAsync("Userconnected", Roomid, id);
        }

        public async Task message(string Roomid, string message, string user)
        {
            await Clients.Group(Roomid).SendAsync("createMessage", message , user);
        }


    }
}
