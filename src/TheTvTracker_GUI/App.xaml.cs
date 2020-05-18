using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using TheTvTracker.ViewModels;
using TheTvTracker.Views;

namespace TheTvTracker
{
  public class App : Application
  {
    public override void Initialize()
    {
      AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
      if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
      {
        desktop.MainWindow = new MainWindow
        {
          DataContext = new MainWindowVM()
        };
      }
      base.OnFrameworkInitializationCompleted();
    }


  }
}
