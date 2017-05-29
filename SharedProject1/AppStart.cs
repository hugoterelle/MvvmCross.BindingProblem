using mvvmcross1.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace mvvmcross1.Core
{
	public class AppStart : IMvxAppStart
	{
		private readonly IMvxNavigationService _navigationService;

		public AppStart(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
		}

		public void Start(object hint = null)
		{
			_navigationService.Navigate<FirstViewModel>();
		}
	}
}