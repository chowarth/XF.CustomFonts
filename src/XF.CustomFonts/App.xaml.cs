using Xamarin.Forms;

[assembly:ExportFont("RobotoMono-Regular.ttf", Alias = "RobotoMono-Regular")]

namespace XF.CustomFonts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
