using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(interview.Startup))]
namespace interview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
