using Microsoft.AspNetCore.SignalR;

namespace SignalR_WebApp.Extensions
{
    public static class PubSubExtensions
    {
        public static void onSubscribed(this IClientProxy clientProxy, string groupName)
        {
            return;
        }

        public static void onUnsubscribed(this IClientProxy clientProxy, string groupName)
        {
            return;
        }

        public static void onNewMsg(this IClientProxy clientProxy, string groupName, object data)
        {
            return;
        }
    }
}
