using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;
using TheTvTracker.Modals;

namespace TheTvTracker.ViewModels
{
  public class UserAdminScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }

    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public ObservableCollection<User> Users { get; }

    public UserAdminScreenVM(IScreen host)
    {
      (host as MainWindowVM).Title = "The TvTracker - Administración de Usuarios";
      HostScreen = host;

      Users = new ObservableCollection<User>();
      LoadUsers();
    }

    private void LoadUsers()
    {
      Users.Clear();
      var users = UserRepo.Instance.GetAll();
      foreach (User u in users)
      {
        Users.Add(u);
      }
    }

    private async void NewUser()
    {
      var window = (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime).MainWindow;
      var modal = new UserModal();
      modal.ShowInTaskbar = false;

      await modal.ShowDialog(window);
      LoadUsers();
    }

    private async void EditUser(User u)
    {
      var window = (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime).MainWindow;
      var modal = new UserModal(u);
      modal.ShowInTaskbar = false;

      await modal.ShowDialog(window);
      LoadUsers();
    }

    private void DeleteUser(User u)
    {
      Users.Remove(u);
      UserRepo.Instance.Remove(u);
    }

    private void GoBack()
    {
      (HostScreen as MainWindowVM).Navigate(new LoginScreenVM(HostScreen));
    }
  }
}
