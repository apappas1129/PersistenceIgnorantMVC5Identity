using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5.Web.Startup))]
namespace MVC5.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
