using ReactiveUI;
using System;
using System.Collections.Generic;

namespace TheTvTracker.Data.Model
{
  public class Series : BaseModel
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

    private IList<Season> _seasons;
    public IList<Season> Seasons
    {
      get => _seasons;
      set => this.RaiseAndSetIfChanged(ref _seasons, value);
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
