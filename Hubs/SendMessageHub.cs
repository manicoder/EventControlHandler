using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventControlHandler.Hubs
{
    public class SendMessageHub : Hub
    {
        public async Task ElementEventSendMessageFromServer(ElementEventHandler values)
        {
            await Clients.All.SendAsync("ElementEventReceiveMessage", values);
        }
    }
}
