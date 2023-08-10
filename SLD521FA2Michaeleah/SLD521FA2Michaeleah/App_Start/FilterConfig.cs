using System.Web;
using System.Web.Mvc;

namespace SLD521_FA2_Michaeleah_Anne_Murray
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
