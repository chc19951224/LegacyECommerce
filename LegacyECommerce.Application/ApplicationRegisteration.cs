using Autofac;
using LegacyECommerce.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application
{
    ///【 應 用 層 注 冊 類 】
    public static class ApplicationRegisteration
    {
        ///【 注 冊 類 方 法 】
        public static ContainerBuilder AddApplication(this ContainerBuilder builder)
        {
            /// 精 準 注 冊
            builder.RegisterType<CategoryService>().AsImplementedInterfaces().InstancePerRequest();

            /// 回 傳 容 器
            return builder;
        }
    }
}
