using ReactiveUI;
using System;

namespace TheTvTracker.Data.Model
{
  public class User : ModelBase
  {
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
  }
}
