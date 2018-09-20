using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPM_Assignment.Startup))]
namespace RPM_Assignment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
