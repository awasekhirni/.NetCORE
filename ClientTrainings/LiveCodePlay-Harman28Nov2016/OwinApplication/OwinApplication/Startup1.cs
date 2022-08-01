using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Hosting;

[assembly: OwinStartup(typeof(OwinApplication.Startup1))]

namespace OwinApplication
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }

        static void Main(string[] args)
        {
            using (WebApp.Start<Startup1>("http://localhost:9000"))
            {
                Console.WriteLine("Listening at port 9000, press [enter ]to exit");
                Console.ReadLine();
            }
        }
    }
}
