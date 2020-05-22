using ReactiveUI;
using System;

namespace TheTvTracker.Data.Model
{
  public class Movie : BaseModel
  {
    private int _id;
    public int Id
    {
      get => _id;
      set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private string _name;
    public string Name
    {
      get => _name;
      set => this.RaiseAndSetIfChanged(ref _name, value);
    }

    private string _summary;
    public string Summary
    {
      get => _summary;
      set => this.RaiseAndSetIfChanged(ref _summary, value);
    }

    private string _poster;
    public string Poster
    {
      get => _poster;
      set => this.RaiseAndSetIfChanged(ref _poster, value);
    }

    private DateTime _releaseDate;
    public DateTime ReleaseDate
    {
      get => _releaseDate;
      set => this.RaiseAndSetIfChanged(ref _releaseDate, value);
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
  }
}
