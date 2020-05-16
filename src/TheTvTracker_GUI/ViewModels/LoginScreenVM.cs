﻿using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using TheTvTracker.Data.Access;
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
      var db = DbHandler.Instance.Db;
      var users = db.GetCollection<User>("Users");
      foreach (User u in users.FindAll())
      {
        Users.Add(u);
      }
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
