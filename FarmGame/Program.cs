using Autofac;
using FarmGame.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //1.0
            //var builder = new ContainerBuilder();

            //// 注册 MsgService 类型
            //builder.RegisterType<MsgService>().AsSelf();

            //// 注册 Form1 类型，并指定构造函数参数为 MsgService 类型的实例
            //builder.RegisterType<Form1>().UsingConstructor(typeof(MsgService));

            //var container = builder.Build();

            //Application.Run(container.Resolve<Form1>());

            //2.0
            //var builder = new ContainerBuilder();

            //// 扫描程序集并自动注册服务类
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //       .Where(t => t.Name.EndsWith("Service")) // 根据命名约定选择要注册的服务类
            //       .AsImplementedInterfaces()
            //       .InstancePerLifetimeScope();

            //// 注册其他需要手动注册的服务

            //var container = builder.Build();

            //Application.Run(container.Resolve<Form1>());


            //2.1
            //var builder = new ContainerBuilder();

            //// 注册服务和其他依赖项
            //builder.RegisterType<Form1>();

            //// 扫描程序集并自动注册其他服务类
            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            //       .Where(t => t.Name.EndsWith("Service"))
            //       .AsImplementedInterfaces()
            //       .InstancePerLifetimeScope();

            //var container = builder.Build();

            //Application.Run(container.Resolve<Form1>());

            //3.0
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //var builder = new ContainerBuilder();

            //// 注册服务和其他依赖项
            //builder.RegisterType<Form1>();

            //var container = builder.Build();

            //// 创建并显示主窗体 Form1
            //var form1 = container.Resolve<Form1>();
            //Application.Run(form1);

            //4.0
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var form1 = scope.Resolve<Form1>();
                Application.Run(form1);
            }
        }

    }
}
