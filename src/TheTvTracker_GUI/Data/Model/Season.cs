using ReactiveUI;
using System;
using System.Collections.Generic;

namespace TheTvTracker.Data.Model
{
  public class Season : BaseModel
  {
    private int _id;
    public int Id
    {
      get => _id;
      set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private int _number;
    public int Number
    {
      get => _number;
      set => this.RaiseAndSetIfChanged(ref _number, value);
    }

    private IList<Episode> _episodes;
    public IList<Episode> Episodes
    {
      get => _episodes;
      set => this.RaiseAndSetIfChanged(ref _episodes, value);
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
