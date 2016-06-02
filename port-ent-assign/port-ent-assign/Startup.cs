using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(port_ent_assign.Startup))]
namespace port_ent_assign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
