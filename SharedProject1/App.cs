using System.Threading.Tasks;
using mvvmcross1.Core.ViewModels;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace mvvmcross1.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

	        Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();
	        var appStart = Mvx.Resolve<IMvxAppStart>();
	        RegisterAppStart(appStart);
		}
    }

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
