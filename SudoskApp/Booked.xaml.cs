using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Booked : ContentPage
	{
		public Booked()
		{
			
			InitializeComponent();
			GetBookedItems();
		}

		async void GetBookedItems()
		{
			ObservableCollection<BookedItem> itemList = await App.AppService.GetBookedItems();
			list.ItemsSource = itemList;
		}

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var item = (BookedItem)e.SelectedItem;
			await App.AppService.Deliver(item.Id);
		}

	}
}

