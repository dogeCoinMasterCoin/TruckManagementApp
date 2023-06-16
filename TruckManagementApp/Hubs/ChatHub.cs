using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace TruckManagementApp.Hubs

{

    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            // Trimite mesajul la toți clienții conectați
            Clients.All.SendAsync("ReceiveMessage", message);
        }
    }


}
