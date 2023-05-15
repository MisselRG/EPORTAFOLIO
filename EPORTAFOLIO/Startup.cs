using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EPORTAFOLIO.Startup))]
namespace EPORTAFOLIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
