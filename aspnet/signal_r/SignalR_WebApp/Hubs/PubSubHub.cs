using Microsoft.AspNetCore.SignalR;
using SignalR_WebApp.Extensions;
using System.Threading.Tasks;

namespace SignalR_WebApp.Hubs
{
    public class PubSubHub : Hub
    {
        public async Task Publish(string groupName, object data)
        {
            await Clients.Groups(groupName).SendAsync(groupName, data.ToString());
            Clients.Groups(groupName).onNewMsg(groupName, data);
        }
        public async Task Subscribe(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            Clients.Client(Context.ConnectionId).onSubscribed(groupName);
        }

        public async Task Unsubscribe(string groupName)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            Clients.Client(Context.ConnectionId).onUnsubscribed(groupName);
        }
    }
}
