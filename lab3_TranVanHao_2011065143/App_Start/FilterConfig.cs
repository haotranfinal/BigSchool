using System.Web;
using System.Web.Mvc;

namespace lab3_TranVanHao_2011065143
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
