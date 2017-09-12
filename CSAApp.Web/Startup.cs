using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSAApp.Web.Startup))]
namespace CSAApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
