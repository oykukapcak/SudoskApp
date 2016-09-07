using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class AddCategory : ContentPage
	{
		public AddCategory()
		{
			InitializeComponent();
		}

		async void OnClicked(object sender, System.EventArgs e)
		{
			await App.AppService.AddCategory(category.ToString());
		}
	}
}

