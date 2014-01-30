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
            var appName = "SignalRScaleout";

            //var serviceBusConnectionString = "myServiceBusConnectionString";
            //GlobalHost.DependencyResolver.UseServiceBus(serviceBusConnectionString, appName);

            //var server = "myRedisServer";
            //var port = 6379;
            //var password = "myPassword";
            //GlobalHost.DependencyResolver.UseRedis(server, port, password, appName);

            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "mySqlServer.com";
            //builder.UserID = "myUserName"; // REQUIRES SCHEMA CREATION RIGHTS
            //builder.Password = "myPassword";
            //builder.InitialCatalog = "scaleout";
            //GlobalHost.DependencyResolver.UseSqlServer(builder.ToString());

            app.MapSignalR();
        }
    }
}