using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class AddEquipment : ContentPage
	{
		public AddEquipment()
		{
			InitializeComponent();
		}

		async void OnClicked(object sender, System.EventArgs e)
		{
			await App.AppService.AddItem(name.ToString(), category.ToString(), description.ToString());
		}
	}
}

