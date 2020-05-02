using ReactiveUI;
using System;

namespace TheTvTracker.ViewModels
{
  public class MainWindowVM : ViewModelBase, IScreen
  {
    public RoutingState Router { get; } = new RoutingState();

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
