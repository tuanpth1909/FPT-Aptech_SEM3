using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Display_Data.Startup))]
namespace Display_Data
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
