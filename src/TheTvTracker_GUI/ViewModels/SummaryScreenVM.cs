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

    private User U { get; }
    public string WelcomeText
    {
      get => $"¡Bienvenido, {U.Username}!";
    } 
    
    public string SummaryText
    {
      get => $"Actualmente tienes {U.Movies.Count} películas en tu librería";
    } 

    public SummaryScreenVM(IScreen host, User u)
    {
      (host as MainWindowVM).Title = "The TvTracker - Resumen";
      HostScreen = host;

      U = u;
    }

    private void SearchMovies()
    {
      (HostScreen as MainWindowVM).Navigate(new MovieSearchScreenVM(HostScreen, U));
    }

    private void SeeMovie(Movie m)
    {
      (HostScreen as MainWindowVM).Navigate(new SingleMovieScreenVM(HostScreen, m, U));
    }
  }
}
