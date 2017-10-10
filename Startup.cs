using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week04Lab.Startup))]
namespace Week04Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
