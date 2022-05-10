using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using WallHavenGetter.Forms;
using WallHavenGetter.Models;

namespace WallHavenGetter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string mutexName = "WallHavenGetter_mutex";
            _ = new Mutex(true, mutexName, out bool createNew);
            if (!createNew)
            {
                MessageBox.Show("应用程序已经在运行");
                Application.Exit();
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            AppContext.Init(serviceProvider);

            var frmmain = AppContext.GetService<FrmMain>();

            Application.Run(frmmain);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //注册配置文件
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("application.json").Build();
            services.AddSingleton(configuration);

            //注册日志
            services.AddLogging(build =>
            {
                build.AddNLog("NLog.config");
            });


            //注册主程序
            services.AddTransient<FrmMain>();
            services.AddTransient<FrmImageShow>();
            services.AddTransient<FrmOptions>();
            services.AddTransient<FrmCache>();



            services.AddSingleton<FrmImageShowParams>();
        }

    }
}