using Avalonia;
using Avalonia.Logging.Serilog;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Splat;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;
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
      // Insert demo users
      User u1 = new User() { Username = "Usuario1", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Smiley.png" };
      User u2 = new User() { Username = "Usuario2", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Sam.png" };
      User u3 = new User() { Username = "Usuario3", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Lady.png" };
      User u4 = new User() { Username = "Usuario4", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Robot.png" };
      User u5 = new User() { Username = "Usuario5", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Alien.png" };

      UserRepo.Instance.AddWithCheck(u1);
      UserRepo.Instance.AddWithCheck(u2);
      UserRepo.Instance.AddWithCheck(u3);
      UserRepo.Instance.AddWithCheck(u4);
      UserRepo.Instance.AddWithCheck(u5);

      // Register views
      Locator.CurrentMutable.Register(() => new LoginScreen(), typeof(IViewFor<LoginScreenVM>));
      Locator.CurrentMutable.Register(() => new SummaryScreen(), typeof(IViewFor<SummaryScreenVM>));
      Locator.CurrentMutable.Register(() => new UserAdminScreen(), typeof(IViewFor<UserAdminScreenVM>));

      return AppBuilder.Configure<App>()
           .UsePlatformDetect()
           .LogToDebug()
           .UseReactiveUI();
    }
  }
}
