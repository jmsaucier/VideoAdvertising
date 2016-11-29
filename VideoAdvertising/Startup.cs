using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoAdvertising.Startup))]
namespace VideoAdvertising
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
