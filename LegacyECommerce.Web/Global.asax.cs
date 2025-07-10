using LegacyECommerce.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebGrease.Configuration;

namespace LegacyECommerce.Web
{
    ///【 全 局 應 用 類 】
    public class MvcApplication : System.Web.HttpApplication
    {
        ///【 應 用 類 方 法 】
        protected void Application_Start()
        {
            AutofacConfig.RegisterDependencies();                      // 注冊依賴注入類方法
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);             // 注冊一般控制器路由類方法
            BundleConfig.RegisterBundles(BundleTable.Bundles);         // 注冊捆綁類方法
        }
    }
}
