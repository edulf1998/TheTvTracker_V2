using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Views
{
  public class MovieSearchScreen : ReactiveUserControl<MovieSearchScreenVM>
  {
    public MovieSearchScreen()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
