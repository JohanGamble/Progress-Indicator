using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ProgressTask.Actions
{
    public class ProgressTaskHub : Hub
    {
        // Method to call upon in unison of event taking place.
        public void Send()
        {
            
        }

        // Method to send data back to client-side
        public static void SendServerData<T>(T data)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<ProgressTaskHub>();
            context.Clients.All.sendServerData(data);
        }
    }
}