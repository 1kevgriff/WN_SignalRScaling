using System.Data.SqlClient;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

namespace SignalRFlash.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            const string appName = "SignalRScaleoutDemo";



            app.MapSignalR();
        }
    }
}