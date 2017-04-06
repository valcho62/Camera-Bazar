
using System.Web.Mvc;


namespace CarDealerApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()
            {
                View = "AnotherError"
            });
            //filters.Add(new LogAttribute());
        }
    }
}
