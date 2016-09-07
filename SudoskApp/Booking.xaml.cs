using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Booking : ContentPage
	{
		int itemId;
		Item myItem = new Item();
		public Booking(int item_id)
		{
			itemId = item_id;

			InitializeComponent();
			GetItemByItemName(item_id);
			GetEvents();
		}

		async void GetItemByItemName(int id)
		{

			myItem = await App.AppService.GetItemById(id);
			this.BindingContext = myItem;

		}

		async void GetEvents()
		{
			ObservableCollection<Event> eventList = await App.AppService.GetEvents();
			picker.BindingContext = eventList;
		}

		async void OnRequestClicked(object sender, System.EventArgs e)
		{
			await App.AppService.Request(myItem.Id, date1.Date, date2.Date, 1, App.user_id); //eventid'yi seçemiyciim şimdi
			await DisplayAlert("Booking Request", "Your request has been sent.", "OK");
			await Navigation.PopAsync();
		}
	}
}

