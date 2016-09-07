using Xamarin.Forms;

namespace SudoskApp
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage()
		{
			InitializeComponent();
		}

		void onLoginClicked(object sender, System.EventArgs e)
		{
			//user authentication için kullanılacak
			var email_input = email.Text;
			var password_input = password.Text;
			//-----//
			Application.Current.MainPage = new NavigationPage(new Menu());
		}

		void onSignupClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new CreateAccount());
		}
	}
}

