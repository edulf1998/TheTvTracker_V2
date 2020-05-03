using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Views
{
  public class UserAdminScreen : ReactiveUserControl<UserAdminScreenVM>
  {
    public UserAdminScreen()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
