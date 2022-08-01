using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Startup
    {
        //App_Start --global.asax file in Web Api
        public void Configuration(IAppBuilder app)
        {
            app.Use(typeof(MW1));

        }
    }


    public class MW1
    {
        public Task Invoke(IDictionary<string, object> env)
        {
            foreach (var key in env.Keys)
            {
                Console.WriteLine("{0},{1}", key, env[key]);
                
            }
            return Task.FromResult(0);
        }
    }
}
