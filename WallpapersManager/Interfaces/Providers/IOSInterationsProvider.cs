using System.Threading.Tasks;

namespace WallpapersManager.Interfaces.Providers
{
    interface IOSInterationsProvider
    {
        Task ChangeWallpapers(string imagePath);
    }
}
