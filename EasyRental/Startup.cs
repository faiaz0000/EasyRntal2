using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EasyRental.Startup))]
namespace EasyRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
