using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LegacyECommerce.Infrastructure;
using LegacyECommerce.Application;
using System.Web.Mvc;
using Autofac.Integration.WebApi;

namespace LegacyECommerce.Web.App_Start
{
    ///【 依 賴 注 入 類 】
    public class AutofacConfig
    {
        ///【 注 入 類 方 法 】
        public static void RegisterDependencies()
        {
            /// 創 建 容 器
            ContainerBuilder builder = new ContainerBuilder();

            /// 控 制 器 注 冊
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            /// 分 層 注 冊
            builder.AddInfrastructure();
            builder.AddApplication();

            /// 創 建 封 裝 好 的 容 器
            var container = builder.Build();

            /// AutoFac 負 責 實 例 化 注 冊 對 象
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}