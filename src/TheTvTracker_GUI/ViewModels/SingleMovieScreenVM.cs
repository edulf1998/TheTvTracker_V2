using ReactiveUI;
using System;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;

namespace TheTvTracker.ViewModels
{
  public class SingleMovieScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }
    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    private User U { get; }
    public Movie M { get; }

    public SingleMovieScreenVM(IScreen hostScreen, Movie m, User u)
    {
      HostScreen = hostScreen;
      U = u;
      M = m;
    }

    private void GoBack()
    {
      (HostScreen as MainWindowVM).Navigate(new SummaryScreenVM(HostScreen, U));
    }

    private void RemoveMovie()
    {
      U.Movies.Remove(M);
      UserRepo.Instance.Update(U);
      GoBack();
    }
  }
}
