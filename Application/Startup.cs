using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Application.Startup))]
namespace Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
