using Autofac;
using LegacyECommerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Infrastructure
{
    ///【 基 礎 設 施 層 注 冊 類 】
    public static class InfrastructureRegisteration
    {
        ///【 注 冊 類 方 法 】
        public static ContainerBuilder AddInfrastructure(this ContainerBuilder builder)
        {
            /// 精 準 注 冊
            builder.RegisterType<MyDbContext>().AsSelf().InstancePerRequest();
            builder.RegisterType<CategoryRepository>().AsImplementedInterfaces().InstancePerRequest();

            /// 回 傳 容 器
            return builder;
        }
    }
}
