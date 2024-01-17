using PAHost.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PAHost
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            UIApplication.Instance.Initialize(new UiInstancePA());
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            UIApplication.Instance.Terminate();
        }
    }
}
