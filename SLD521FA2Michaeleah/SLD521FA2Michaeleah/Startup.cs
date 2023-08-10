using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SLD521_FA2_Michaeleah_Anne_Murray.Startup))]
namespace SLD521_FA2_Michaeleah_Anne_Murray
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
