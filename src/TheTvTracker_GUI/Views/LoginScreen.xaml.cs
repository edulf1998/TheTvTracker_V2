using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Views
{
  public class LoginScreen : ReactiveUserControl<LoginScreenVM>
  {
    public LoginScreen()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
