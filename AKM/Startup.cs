using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AKM.Startup))]
namespace AKM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
