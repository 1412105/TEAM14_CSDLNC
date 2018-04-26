using System.Web;
using System.Web.Mvc;

namespace TEAM14_CSDLNC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
