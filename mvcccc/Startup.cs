using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcccc.Startup))]
namespace mvcccc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
