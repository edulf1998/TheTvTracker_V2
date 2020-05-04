using ReactiveUI;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheTvTracker.Data.Model
{
  public class User : ModelBase
  {
    private int _id;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id
    {
      get => _id;
      set => this.RaiseAndSetIfChanged(ref _id, value);
    }

    private string _username;

    [Required]
    [MaxLength(10)]
    public string Username
    {
      get => _username;
      set => this.RaiseAndSetIfChanged(ref _username, value);
    }

    private string _avatar;

    [Required]
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
  }
}
