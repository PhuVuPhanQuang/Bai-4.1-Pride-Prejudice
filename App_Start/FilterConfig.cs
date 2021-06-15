using System.Web;
using System.Web.Mvc;

namespace Bai_4._1_Pride_Prejudice
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
