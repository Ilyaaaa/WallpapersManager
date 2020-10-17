using System;
using System.Threading.Tasks;
using WallpapersManager.Interfaces.Providers;
using WallpapersManager.Interfaces.Services;

namespace WallpapersManager.Services
{
    class OSInteractionsService : IOSInteractionsService
    {
        #region Properties

        private IOSInterationsProvider OSInterationsProvider{ get; }

        #endregion

        #region Constructors

        public OSInteractionsService(IOSInterationsProvider oSInterationsProvider)
        {
            OSInterationsProvider = OSInterationsProvider;
        }

        #endregion

        #region Public functions

        public Task ChangeWallpapers(string imagePath)
        {
            return OSInterationsProvider.ChangeWallpapers(imagePath);
        }

        #endregion
    }
}
