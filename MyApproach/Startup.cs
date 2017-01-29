using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyApproach.Startup))]
namespace MyApproach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
