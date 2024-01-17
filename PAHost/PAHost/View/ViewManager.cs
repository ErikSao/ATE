using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Panuon.WPF.UI;

namespace PAHost.View
{
    public class ViewManager
    {
        public ImageSource SystemLogo { get; set; }
        public string SystemName { get; set; }
        public event Action OnMainWindowLoaded;

        public WindowX MainWindow
        {
            get { return _mainView; }
        }
        private MainView _mainView;

        public ViewManager()
        {
            
        }
        public void InitWindow(bool EnableAccount)
        {
            _mainView = new MainView()
            {
                Icon = SystemLogo,
                Title = SystemName,
            };

            _mainView.UpdateLayout();
            _mainView.Closing += new CancelEventHandler(_mainView_Closing);
            _mainView.Loaded += new RoutedEventHandler(_mainView_Loaded);

            if (EnableAccount)
                _mainView.Show();
        }

        void _mainView_Loaded(object sender, RoutedEventArgs e)
        {
            if (OnMainWindowLoaded != null)
                OnMainWindowLoaded();
        }
        void _mainView_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
