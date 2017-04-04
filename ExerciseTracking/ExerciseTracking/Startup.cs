using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExerciseTracking.Startup))]
namespace ExerciseTracking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
