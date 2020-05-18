using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using System.ComponentModel;
using TheTvTracker.Data.Model;
using TheTvTracker.Data.Repos;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Modals
{
  public class UserModal : Window
  {
    public UserModal()
    {
      InitializeComponent();
      this.AttachDevTools(new KeyGesture(Key.F12, KeyModifiers.Control));

      DataContext = new UserModalVM(this);
    }

    public UserModal(User u)
    {
      InitializeComponent();
      this.AttachDevTools(new KeyGesture(Key.F12, KeyModifiers.Control));

      DataContext = new UserModalVM(u, this);
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
