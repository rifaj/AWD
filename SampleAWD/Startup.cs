using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_AWD.Startup))]
namespace Sample_AWD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
