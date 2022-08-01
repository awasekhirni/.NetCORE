using System.Web;
using System.Web.Mvc;

namespace _29Nov2016DemoAppAreas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
