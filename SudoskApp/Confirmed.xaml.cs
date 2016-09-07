using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Confirmed : ContentPage
	{
		public Confirmed()
		{
			InitializeComponent();
			GetConfirmedItems();
		}

		async void GetConfirmedItems()
		{
			ObservableCollection<ConfirmedItem> itemList = await App.AppService.GetConfirmedItems();
			list.ItemsSource = itemList;
		}

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var item = (BookedItem)e.SelectedItem;
			await App.AppService.Book(item.Id);
		}
	}
}

