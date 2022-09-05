using Microsoft.AspNetCore.SignalR;
using SignalR_WebApp.Model;
using System.Threading.Tasks;

namespace SignalR_WebApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string texto)
        {
            Message mensagem = new Message(user, texto);
            await Clients.All.SendAsync("ReceiveMessage", mensagem.User, mensagem.Texto);
        }
    }
}