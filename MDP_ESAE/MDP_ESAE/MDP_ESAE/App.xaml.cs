using MDP_ESAE.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MDP_ESAE
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();


            SetMainPage();

        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    /*new NavigationPage(new ItemsPage())
                    {
                        Title = "Browse",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AboutPage())
                    {
                        Title = "About",
                        Icon = Device.OnPlatform("tab_about.png",null,null)
                    },*/
                    new NavigationPage(new PerfilPage())
                    {
                        Title = "Perfil"
                    },
                    new NavigationPage(new OfertasPage())
                    {
                        Title = "Ofertas Formativas"
                        //Icon =
                    },
                    new NavigationPage(new DocumentosPage())
                    {
                        Title = "Documentos Académicos"
                    },
                    new NavigationPage(new CalendarioPage())
                    {
                        Title = "Calendário"
                    },
                    new NavigationPage(new SobrePage())
                    {
                        Title = "Sobre ESAE"
                    }
                }
            };
        }
    }
}
