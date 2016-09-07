using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Requested: ContentPage
	{
		public Requested()
		{
			InitializeComponent();
			GetRequestedItems();
		}

		async void GetRequestedItems()
		{
			ObservableCollection<RequestedItem> itemList = await App.AppService.GetRequestedItems();
			list.ItemsSource = itemList;

		}

		async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var item = e.Item as RequestedItem;
			await App.AppService.Confirm(item.Id);
			await DisplayAlert("Confirm", "Request has been confirmed.", "OK");
		}
	}
}

