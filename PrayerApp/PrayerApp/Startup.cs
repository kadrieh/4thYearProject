using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrayerApp.Startup))]
namespace PrayerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
