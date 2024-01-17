
using System.Windows.Media;

namespace PAHost.Base
{
    public interface IUiInstance
    {
        string SystemName { get; }
        ImageSource SystemLogo { get; }
        bool EnableAccount { get; }
    }
}
