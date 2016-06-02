using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio_assignment1.Startup))]
namespace portfolio_assignment1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
