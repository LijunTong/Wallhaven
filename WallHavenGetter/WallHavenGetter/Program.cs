using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using WallHavenGetter.Forms;
using WallHavenGetter.Models;
using WallHavenGetter.Services;
using WallHavenGetter.Utils;

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
                MessageBox.Show("Ӧ�ó����Ѿ�������");
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
            //ע�������ļ� >>ʹ��ini
            //IConfiguration configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("application.json").Build();
            //services.AddSingleton(configuration);

            //ע����־
            services.AddLogging(build =>
            {
                build.AddNLog("NLog.config");
            });

            //ע��ini��д��
            string path = Path.Combine(Directory.GetCurrentDirectory(), "application.ini");
            IniFileHelper iniFileHelper = new IniFileHelper(path);
            services.AddSingleton<IniFileHelper>(iniFileHelper);

            

            //ע��������
            services.AddTransient<FrmMain>();
            services.AddTransient<FrmImageShow>();
            services.AddTransient<FrmOptions>();
            services.AddTransient<FrmCache>();

            //ע��ҵ����
            services.AddSingleton<FrmImageShowParams>();
            services.AddTransient<OptionsService>();
            services.AddTransient<WhHtmlParseService>();
        }

    }
}