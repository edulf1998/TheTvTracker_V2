using ReactiveUI;

namespace TheTvTracker.ViewModels
{
  public class MainWindowVM : ViewModelBase, IScreen
  {
    public RoutingState Router { get; } = new RoutingState();

    private string _title;
    public string Title
    {
      get => _title;
      set => this.RaiseAndSetIfChanged(ref _title, value);
    }

    public MainWindowVM()
    {
      Navigate(new LoginScreenVM(this));
    }

    public void Navigate(IRoutableViewModel vm)
    {
      Router.Navigate.Execute(vm);
    }
  }
}
