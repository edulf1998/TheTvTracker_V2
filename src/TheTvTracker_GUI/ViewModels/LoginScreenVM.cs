using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using TheTvTracker.Data.Model;

namespace TheTvTracker.ViewModels
{
  public class LoginScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }

    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public ObservableCollection<User> Users { get; }

    public LoginScreenVM(IScreen screen)
    {
      (screen as MainWindowVM).Title = "TheTvTracker - Login";

      HostScreen = screen;
      Users = new ObservableCollection<User>();
      LoadUsers();
    }

    private void LoadUsers()
    {
      User u1 = new User() { Username = "Usuario1", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Smiley.png" };
      Users?.Add(u1);

      User u2 = new User() { Username = "Usuario2", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Sam.png" };
      Users?.Add(u2);

      User u3 = new User() { Username = "Usuario3", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Lady.png" };
      Users?.Add(u3);

      User u4 = new User() { Username = "Usuario4", Avatar = "avares://TheTvTracker_GUI/Assets/Avatars/Robot.png" };
      Users?.Add(u4);
    }

    private void UserLogin(User u)
    {
      (HostScreen as MainWindowVM).Navigate(new SummaryScreenVM(HostScreen, u));
    }

    private void AdminProfiles()
    {
      (HostScreen as MainWindowVM).Navigate(new UserAdminScreenVM(HostScreen));
    }
  }
}
