
using PAHost.Base;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PAHost
{
    public class UiInstancePA : IUiInstance
    {
        public string SystemName => "HIROKAWA";

        public ImageSource SystemLogo => new BitmapImage(new Uri("pack://application:,,,/PAHost;component/Resources/images/GC.png"));

        public bool EnableAccount => false;
    }
}
