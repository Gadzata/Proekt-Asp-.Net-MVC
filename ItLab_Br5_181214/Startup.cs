using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItLab_Br5_181214.Startup))]
namespace ItLab_Br5_181214
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
