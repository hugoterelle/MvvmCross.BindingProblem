using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace mvvmcross1.Core.ViewModels
{
	public class BaseViewModel : MvxViewModel
	{

	}

	public class FirstViewModel
		: BaseViewModel
	{
		public string Hello { get; set; } = "Hello World";
		public string Hello2 { get; set; } = "Hello World 2";

		public bool IsVisible { get; set; }
		public bool IsVisible2 { get; set; }

		public override void Start()
		{
			base.Start();
			Task.Run(async () =>
			{
				for (var i = 0; i < 100; i++)
				{
					await Task.Delay(1000);
					IsVisible = !IsVisible;
				}
			});
		}

		public override async Task Initialize()
		{
			await base.Initialize();
			for (var i = 0; i < 100; i++)
			{
				await Task.Delay(1000);
				IsVisible2 = !IsVisible2;
			}
		}
	}
}
