using ReactiveUI;
using System;

namespace TheTvTracker.ViewModels
{
  public class UserAdminScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }

    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public UserAdminScreenVM(IScreen host)
    {
      (host as MainWindowVM).Title = "The TvTracker - Administración de Usuarios";
      HostScreen = host;
    }

    private void GoBack()
    {
      (HostScreen as MainWindowVM).NavigateBack();
    }
  }
}
