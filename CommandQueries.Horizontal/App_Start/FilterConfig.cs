using System.Web;
using System.Web.Mvc;

namespace CommandQueries.Horizontal
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}