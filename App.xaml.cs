namespace PM02NetMaui_Tarea1_2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.PageRegister());//Agregamos la navegacion entre paginas
        }
    }
}