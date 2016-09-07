using Xamarin.Forms;

namespace SudoskApp
{
	public partial class App : Application
	{
		public static RestService AppService = new RestService();
		public static int user_id = 1;
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new FirstPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

