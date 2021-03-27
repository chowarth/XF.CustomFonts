using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.CustomFonts.ViewModels;

namespace XF.CustomFonts.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontIconPage : ContentPage
    {
        public FontIconPage()
        {
            InitializeComponent();

            BindingContext = new FontIconPageViewModel();
        }
    }
}