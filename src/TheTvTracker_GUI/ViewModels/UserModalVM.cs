using ReactiveUI;
using System.Collections.ObjectModel;
using System.Linq;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;
using TheTvTracker.Modals;

namespace TheTvTracker.ViewModels
{
  public class UserModalVM : ViewModelBase
  {
    private User _u;
    public User U
    {
      get => _u;
      set => this.RaiseAndSetIfChanged(ref _u, value);
    }

    private bool Editing { get; }
    private UserModal Owner { get; }

    public ObservableCollection<string> Avatars { get; set; }
    public string SelectedAvatar { get; set; }

    public UserModalVM(UserModal owner)
    {
      Editing = false;
      U = new User();
      Owner = owner;

      Avatars = new ObservableCollection<string>();
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Alien.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Chicken.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Hero.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Lady.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Ninja.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Penguin.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Pirate.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Raccoon.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Robot.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Sam.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Smiley.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Thief.png");
      SelectedAvatar = Avatars.First();
    }

    public UserModalVM(User u, UserModal owner)
    {
      Editing = true;
      U = u;
      Owner = owner;

      Avatars = new ObservableCollection<string>();
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Alien.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Chicken.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Hero.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Lady.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Ninja.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Penguin.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Pirate.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Raccoon.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Robot.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Sam.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Smiley.png");
      Avatars.Add("avares://TheTvTracker_GUI/Assets/Avatars/Thief.png");
      SelectedAvatar = U.Avatar;
    }

    private void SaveChanges()
    {
      U.Avatar = SelectedAvatar;
      if (Editing)
      {
        UserRepo.Instance.Update(U);
      }
      else
      {
        UserRepo.Instance.AddWithCheck(U);
      }
      Owner.Close();
    }
  }
}
