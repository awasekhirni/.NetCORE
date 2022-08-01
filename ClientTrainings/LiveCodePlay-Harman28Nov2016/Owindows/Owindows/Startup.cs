using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

[assembly: OwinStartup(typeof(Owindows.Startup))]

namespace Owindows
{
    // global asax file 
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            HttpConfiguration httpConfiguration = new HttpConfiguration();
            WebApiConfig.Register(httpConfiguration);
            app.UseWebApi(httpConfiguration);


            //json serialization code 

            var defaultSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                        {
                            new StringEnumConverter{ CamelCaseText = true },
                        }
            };

            JsonConvert.DefaultSettings = () => { return defaultSettings; };

            httpConfiguration.Formatters.Clear();
            httpConfiguration.Formatters.Add(new JsonMediaTypeFormatter());
            httpConfiguration.Formatters.JsonFormatter.SerializerSettings = defaultSettings;

            //end of json serialization code

        }
    }
}
