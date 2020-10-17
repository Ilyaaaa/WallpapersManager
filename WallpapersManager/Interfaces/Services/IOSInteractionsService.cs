using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WallpapersManager.Interfaces.Services
{
    interface IOSInteractionsService
    {
        Task ChangeWallpapers(string imagePath);
    }
}
