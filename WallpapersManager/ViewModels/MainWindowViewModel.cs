using Core.Interfaces;
using Core.Interfaces.Services;
using ReactiveUI;
using Splat;
using System;
using System.Reactive;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace WallpapersManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        public ReactiveCommand<Unit, Unit> ChangeWallpapersCommand { get; }

        #endregion

        #region Constructors

        public MainWindowViewModel()
        {
            var api = Locator.Current.GetService<IUnsplashApiService>();
            //ChangeWallpapersCommand = ReactiveCommand.Create(ChangeWallpapers);
            
            var result = Task.Run(async () => await api.GetRandomImage()).Result;

            var wc = new System.Net.WebClient();
            var path = @"d:\" + result.Content.Id;
            wc.DownloadFile(result.Content.Links.Download, path);
            //ChangeWallpapers(path);
        }

        #endregion
    }
}
