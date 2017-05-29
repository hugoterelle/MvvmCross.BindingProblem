using System.Threading.Tasks;
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
}
