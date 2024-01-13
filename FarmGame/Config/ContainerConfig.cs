using Autofac;
using Autofac.Features.AttributeFilters;
using FarmGame.Service.Msg;
using FarmGame.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FarmGame.Config
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // 注册你的依赖项
            //builder.RegisterType<MsgService>().As<IMsgService>();
            //builder.RegisterType<MsgService2>().As<IMsgService>();
            builder.RegisterType<MsgService>().Keyed<IMsgService>("msgService");
            builder.RegisterType<MsgService2>().Keyed<IMsgService>("msgService2");

            //随机业务服务
            builder.RegisterType<RandomHelper>();

            builder.RegisterType<Form1>().WithAttributeFiltering();


            return builder.Build();
        }
    }
}
