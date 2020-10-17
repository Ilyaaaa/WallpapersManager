using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Core.Interfaces.Services;
using Core.Services;
using Splat;
using WallpapersManager.ViewModels;
using WallpapersManager.Views;

namespace WallpapersManager
{
    public class App : Application
    {
        public override void Initialize()
        {
            Locator.CurrentMutable.RegisterLazySingleton<IUnsplashApiService>(() => new UnsplashApiService());

            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
