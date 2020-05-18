using ReactiveUI;
using System;

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

    private Series _following;
    public Series Following
    {
      get => _following;
      set => this.RaiseAndSetIfChanged(ref _following, value);
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
