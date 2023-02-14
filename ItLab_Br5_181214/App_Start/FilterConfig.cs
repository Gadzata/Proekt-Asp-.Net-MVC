using System.Web;
using System.Web.Mvc;

namespace ItLab_Br5_181214
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
