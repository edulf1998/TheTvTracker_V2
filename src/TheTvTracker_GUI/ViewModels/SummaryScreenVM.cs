using ReactiveUI;
using System;
using TheTvTracker.Data.Model;

namespace TheTvTracker.ViewModels
{
  public class SummaryScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }

    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public SummaryScreenVM(IScreen host, User u)
    {
      (host as MainWindowVM).Title = "The TvTracker - Resumen";
      HostScreen = host;
    }
  }
}
