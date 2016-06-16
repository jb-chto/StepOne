using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StepOne.Startup))]
namespace StepOne
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
