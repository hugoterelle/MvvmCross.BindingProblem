using Android.App;
using Android.OS;
using mvvmcross1.Core.ViewModels;

namespace mvvmcross1.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : BaseView<FirstViewModel>
    {
        protected override int LayoutResource => Resource.Layout.FirstView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SupportActionBar.SetDisplayHomeAsUpEnabled(false);
        }
    }
}
