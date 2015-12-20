using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComesticOhui.Startup))]
namespace ComesticOhui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
