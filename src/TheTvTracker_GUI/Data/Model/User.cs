using ReactiveUI;
using System;
using System.Collections;
using System.Collections.Generic;

namespace TheTvTracker.Data.Model
{
  public class User : BaseModel
  {
    private int _id;
    public int Id
    {
      get => _id;
      set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private string _username;
    public string Username
    {
      get => _username;
      set => this.RaiseAndSetIfChanged(ref _username, value);
    }

    private string _avatar;
    public string Avatar
    {
      get => _avatar;
      set => this.RaiseAndSetIfChanged(ref _avatar, value);
    }
    
    private DateTime _lastLogin;
    public DateTime LastLogin
    {
      get => _lastLogin;
      set => this.RaiseAndSetIfChanged(ref _lastLogin, value);
    }

    private IList<Series> _series;
    public IList<Series> Series
    {
      get => _series;
      set => this.RaiseAndSetIfChanged(ref _series, value);
    }
    
    private IList<Movie> _movies;
    public IList<Movie> Movies
    {
      get => _movies;
      set => this.RaiseAndSetIfChanged(ref _movies, value);
    }

    private DateTime _created;
    public DateTime Created
    {
      get => _created;
      set => this.RaiseAndSetIfChanged(ref _created, value);
    }

    private DateTime _updated;
    public DateTime Updated
    {
      get => _updated;
      set => this.RaiseAndSetIfChanged(ref _updated, value);
    }

    public User()
    {
      Series = new List<Series>();
      Movies = new List<Movie>();
    }
  }
}
