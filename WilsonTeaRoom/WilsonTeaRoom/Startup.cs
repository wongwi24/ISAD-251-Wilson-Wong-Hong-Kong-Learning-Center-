using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WilsonTeaRoom.Startup))]
namespace WilsonTeaRoom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
