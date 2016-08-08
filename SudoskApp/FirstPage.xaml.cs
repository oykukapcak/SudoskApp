using Xamarin.Forms;

namespace SudoskApp
{
	public partial class FirstPage : ContentPage
	{
		public FirstPage()
		{
			InitializeComponent();
		}

		void onClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new CreateAccount());
		}
	}
}

