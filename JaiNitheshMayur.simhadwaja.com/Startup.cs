using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaiNitheshMayur.simhadwaja.com.Startup))]
namespace JaiNitheshMayur.simhadwaja.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
