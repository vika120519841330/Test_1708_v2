using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TEST_170819.Startup))]
namespace TEST_170819
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
