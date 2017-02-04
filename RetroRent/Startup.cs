using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetroRent.Startup))]
namespace RetroRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
