using Xamarin.Forms;
using XF.CustomFonts.Pages;

[assembly:ExportFont("materialdesignicons-webfont.ttf", Alias = "MaterialDesignIcons")]
[assembly:ExportFont("RobotoMono-Regular.ttf", Alias = "RobotoMono-Regular")]

namespace XF.CustomFonts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new FontIconPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
