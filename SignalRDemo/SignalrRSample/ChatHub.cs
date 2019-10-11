﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalrRSample
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message) 
        {
            await Clients.All.SendAsync("EmpfangeNachricht", message);
        } 
    }
}