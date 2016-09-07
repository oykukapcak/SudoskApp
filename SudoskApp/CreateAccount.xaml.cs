using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class CreateAccount : ContentPage
	{
		public CreateAccount()
		{
			InitializeComponent();
		}

		async void OnClicked(object sender, System.EventArgs e)
		{
			await App.AppService.AddMemberRequest(name.ToString(), surname.ToString(), email.ToString());
		}
	}
}

