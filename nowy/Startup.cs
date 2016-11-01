using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nowy.Startup))]
namespace nowy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
