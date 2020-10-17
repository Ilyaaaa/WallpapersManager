using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WallpapersManager.Interfaces.Providers;

namespace WallpapersManager.Providers
{
    class WindowsInterationsProvider : IOSInterationsProvider
    {
        #region Members

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int action, int param, string lpvParam, int fuWinIni);

        private const int SetDesktopBackgroundFlag = 20;
        private const int UpdateIniFileFlag = 1;
        private const int SendWindowsIniChangeFlag = 2;

        #endregion

        #region Public functions

        public Task ChangeWallpapers(string imagePath)
        {
            return Task.Run(() => SystemParametersInfo(SetDesktopBackgroundFlag, 0, imagePath, UpdateIniFileFlag | SendWindowsIniChangeFlag));
        }

        #endregion
    }
}
