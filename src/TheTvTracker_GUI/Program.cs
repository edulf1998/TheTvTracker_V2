using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Splat;
using TheTvTracker.ViewModels;
using TheTvTracker.Views;

namespace TheTvTracker
{
  class Program
  {
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
    {
      // Register views
      Locator.CurrentMutable.Register(() => new LoginScreen(), typeof(IViewFor<LoginScreenVM>));

      return AppBuilder.Configure<App>()
           .UsePlatformDetect()
           .LogToDebug()
           .UseReactiveUI();
    }
  }
}
