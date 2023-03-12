using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_TranVanHao_2011065143.Startup))]
namespace lab3_TranVanHao_2011065143
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
