using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopCart.WebUI.Startup))]
namespace ShopCart.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
