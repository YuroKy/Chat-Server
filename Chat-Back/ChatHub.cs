using System.Threading.Tasks;
using Chat_Back.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat_Back
{
    public class ChatHub : Hub
    {
        public Task SendAsync(Message message)
        {
            return Clients.All.SendAsync("SendAsync", message);
        }
    }
}