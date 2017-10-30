using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartsInParcels.Startup))]
namespace PartsInParcels
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
