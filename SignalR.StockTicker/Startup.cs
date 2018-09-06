using Microsoft.Owin;
using Owin;
using SignalR.StockTicker;

[assembly: OwinStartup(typeof(Startup))]

namespace SignalR.StockTicker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}