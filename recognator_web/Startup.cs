using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(recognator_web.Startup))]
namespace recognator_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
