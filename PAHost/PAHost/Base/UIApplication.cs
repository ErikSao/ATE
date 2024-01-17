using System;
using System.Threading;
using System.Windows.Forms;
using PACommon.Log;
using PAHost.View;
using Panuon.WPF.UI;

namespace PAHost.Base
{
    public class UIApplication : Singleton<UIApplication>
    {
        private IUiInstance _instance;
        public IUiInstance Current
        {
            get { return _instance; }
        }
        public event Action OnWindowsLoaded;
        private ViewManager _views;
        static ThreadExceptionEventHandler ThreadHandler = new ThreadExceptionEventHandler(Application_ThreadException);
        public UIApplication()
        {

        }
        public void Initialize(IUiInstance instance)
        {

            //捕捉异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);

            Application.ThreadException += ThreadHandler;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            _instance = instance;
            Init();
        }
        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            Application.ThreadException -= ThreadHandler;
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowMessageDialog(e.Exception);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowMessageDialog((Exception)e.ExceptionObject);
        }


        static void ShowMessageDialog(Exception ex)
        {
            try
            {
                MessageBox.Show(string.Format("{0} UI Inner Exception, {1}", "", ex.Message));
            }
            finally
            {
                //Environment.Exit(0);
            }
        }

        public void Terminate()
        {
            //程序退出，关闭串口，释放等操作

            Singleton<LogManager>.Instance.Terminate();
        }
        public bool Init()
        {

            try
            {
                Singleton<LogManager>.Instance.Initialize();

                // 启动初始化等
                _views = new ViewManager()
                {
                    SystemLogo = _instance.SystemLogo,
                    SystemName = _instance.SystemName,
                };
                _views.OnMainWindowLoaded += views_OnMainWindowLoaded;
                _views.InitWindow(!_instance.EnableAccount);

                if (_instance.EnableAccount)
                {
                    MainLogin mainLogin = new MainLogin();
                    if (mainLogin.ShowDialog() == true)
                    {
                        _views.MainWindow.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxX.Show("Initialize failed, " + ex.Message, "a", System.Windows.MessageBoxButton.OK, Panuon.WPF.UI.MessageBoxIcon.Warning, DefaultButton.YesOK);
                return false;
            }

            return true;
        }
        void views_OnMainWindowLoaded()
        {
            if (OnWindowsLoaded != null)
                OnWindowsLoaded();
        }
    }
}

