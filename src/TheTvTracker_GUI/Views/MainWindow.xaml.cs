using Avalonia;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using TheTvTracker.ViewModels;

namespace TheTvTracker.Views
{
  public class MainWindow : ReactiveWindow<MainWindowVM>
  {
    public MainWindow()
    {
      InitializeComponent();
      this.AttachDevTools(new KeyGesture(Key.F12, KeyModifiers.Control));
    }

    private void InitializeComponent()
    {
      AvaloniaXamlLoader.Load(this);
    }
  }
}
