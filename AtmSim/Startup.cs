using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtmSim.Startup))]
namespace AtmSim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
