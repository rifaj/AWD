using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWD.Startup))]
namespace AWD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
