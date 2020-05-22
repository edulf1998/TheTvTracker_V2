using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Threading.Tasks;
using TheTvTracker.Data.Access;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;

namespace TheTvTracker.ViewModels
{
  public class MovieSearchScreenVM : ViewModelBase, IRoutableViewModel
  {
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }
    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    private User U { get; }
    public ObservableCollection<Movie> SearchResults { get; }

    private string _queryText;
    public string QueryText
    {
      get => _queryText;
      set => this.RaiseAndSetIfChanged(ref _queryText, value);
    }

    public ReactiveCommand<Unit, Task> Search { get; }

    public MovieSearchScreenVM(IScreen host, User u)
    {
      HostScreen = host;
      U = u;

      SearchResults = new ObservableCollection<Movie>();
      Search = ReactiveCommand.CreateFromTask(SearchMovie);
    }

    private async Task<Task> SearchMovie()
    {
      if(!string.IsNullOrEmpty(QueryText))
      {
        // Query text is not empty
        var movies =  await NetworkHelper.Instance.SearchMovies(QueryText);

        SearchResults.Clear();
        foreach(Movie m in movies)
        {
          SearchResults.Add(m);
        }
      }

      return Task.CompletedTask;
    }

    private void AddMovie(Movie m)
    {
      U.Movies.Add(m);
      UserRepo.Instance.Update(U);
    }

    private void GoBack()
    {
      (HostScreen as MainWindowVM).Navigate(new SummaryScreenVM(HostScreen, U));
    }
  }
}
