using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hello_world.Startup))]
namespace hello_world
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
