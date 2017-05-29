using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace mvvmcross1.Core.ViewModels
{
	public class BaseViewModel : MvxViewModel
	{

	}

	public class FirstViewModel : BaseViewModel
	{
    private string _hello = "Hello World";
	  public string Hello
	  {
	    get => _hello;
	    set
	    {
	      _hello = value;
        RaisePropertyChanged(() => Hello);
	    }
	  }

	  private string _hello2 = "Hello World 2";
	  public string Hello2
	  {
	    get => _hello2;

	    set
	    {
	      _hello2 = value;
        RaisePropertyChanged(() => Hello2);
	    }
	  }

	  private string _hello3;
	  public string Hello3
	  {
	    get => _hello3;
	    set
	    {
	      _hello3 = value; 
	      RaisePropertyChanged(() => Hello3);
	    }
	  }

	  private bool _isVisible;
	  public bool IsVisible
	  {
	    get => _isVisible;
	    set
	    {
	      _isVisible = value;
	      RaisePropertyChanged(() => IsVisible);
	    }
	  }

	  private bool _isVisible2;
	  public bool IsVisible2
	  {
	    get => _isVisible2;
	    set
	    {
	      _isVisible2 = value; 
	      RaisePropertyChanged(() => IsVisible2);
	    }
	  }

	  public override void Start()
		{
			base.Start();
			Task.Run(async () =>
			{
				for (var i = 0; i < 100; i++)
				{
					await Task.Delay(1000);
					IsVisible = !IsVisible;
				  Hello = IsVisible ? "Test 1" : "Test 2";
        }
			});
		}

		public override async Task Initialize()
		{
		  ShouldAlwaysRaiseInpcOnUserInterfaceThread(true);
			await base.Initialize();
			for (var i = 0; i < 100; i++)
			{
				await Task.Delay(1000);
				IsVisible2 = !IsVisible2;
				Hello2 = IsVisible2 ? "Test 1" : "Test 2";
			}
		}

	  public IMvxAsyncCommand SetHello3Command => new MvxAsyncCommand(() => Task.Run(() => Hello3 = Hello));
  }
}
