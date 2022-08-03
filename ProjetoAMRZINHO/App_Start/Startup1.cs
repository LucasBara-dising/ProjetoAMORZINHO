using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(ProjetoAMRZINHO.App_Start.Startup1))]

namespace ProjetoAMRZINHO.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                AuthenticationType ="ApplApplicationCookia",
                LoginPath = new PathString("Autentitacao/Login")
            });
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
