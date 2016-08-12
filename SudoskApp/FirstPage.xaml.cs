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
			Navigation.PushAsync(new Menu());
		}

		void onSignupClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new CreateAccount());
		}
	}
}

