using project_picaso.views;
namespace project_picaso
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashBoardView();
        }
    }
}