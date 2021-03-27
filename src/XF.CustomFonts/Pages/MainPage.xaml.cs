using Xamarin.Forms;
using XF.CustomFonts.ViewModels;

namespace XF.CustomFonts.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}
