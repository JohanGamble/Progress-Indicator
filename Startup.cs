using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProgressTask.Startup))]

namespace ProgressTask
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
