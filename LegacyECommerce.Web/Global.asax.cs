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
    ///�� ȫ �� �� �� � ��
    public class MvcApplication : System.Web.HttpApplication
    {
        ///�� �� �� � �� �� ��
        protected void Application_Start()
        {
            AutofacConfig.RegisterDependencies();                      // ע����هע�����
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);             // ע��һ�������·�����
            BundleConfig.RegisterBundles(BundleTable.Bundles);         // ע���������
        }
    }
}
