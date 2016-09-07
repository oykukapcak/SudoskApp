using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class MyItems : ContentPage
	{
		public MyItems()
		{
			InitializeComponent();
			GetItemsByUserId(App.user_id);
		}

		async void GetItemsByUserId(int id)
		{
			ObservableCollection<Item> itemList = await App.AppService.GetItemsByUser(id);


			list.ItemsSource = itemList;
		}

		string status(int num)
		{
			if (num == 1)
				return "Requested";
			else if (num == 2)
				return "Confirmed";
			else
				return "Booked";
		}
	}
}

