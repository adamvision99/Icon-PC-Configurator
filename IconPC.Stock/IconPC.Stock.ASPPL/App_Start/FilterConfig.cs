using System.Web;
using System.Web.Mvc;

namespace IconPC.Stock.ASPPL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
