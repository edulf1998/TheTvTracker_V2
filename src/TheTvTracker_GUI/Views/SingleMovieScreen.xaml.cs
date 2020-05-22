using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Views
{
  public class SingleMovieScreen : ReactiveUserControl<SingleMovieScreenVM>
  {
    public SingleMovieScreen()
    {
      this.InitializeComponent();
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
