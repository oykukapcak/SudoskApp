using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class ItemBrowsePage : ContentPage
	{
		int categoryId;
		public ItemBrowsePage(int id)
		{
			categoryId = id;

			InitializeComponent();
			GetItemsByCategory(categoryId);
		}


		async void GetItemsByCategory(int id)
		{

			ObservableCollection<Item> itemList = await App.AppService.GetItemsByCategoryId(id);
			list.ItemsSource = itemList;
		}

		void OnSearchClicked(object sender, System.EventArgs e)
		{
			//list.ItemsSource = new ObservableCollection<Item>() { new Item() { Id = 2, Name = "Orange Marmot" }};
			SearchItemsByDate(beginDate.Date, endDate.Date);
		}

		async void SearchItemsByDate(System.DateTime date1, System.DateTime date2)
		{
			ObservableCollection<Item> itemList = await App.AppService.GetItemsByCategoryId(categoryId);
			ObservableCollection<Item> resultItemList = new ObservableCollection<Item>();
			foreach (var item in itemList)
			{
				if (item.Status != 0)
				{
					if (!(item.BeginDate >= date1 && item.EndDate <= date2))
					{
						resultItemList.Add(item);
					}
				}
				else
				{
					resultItemList.Add(item);	
				}
			}
			list.ItemsSource = resultItemList;
		}

		void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			//o item'ın booking page'ine gidicek
			//item idsini de yolliycasss
			var item= (Item)e.SelectedItem;
			Navigation.PushAsync(new Booking(item.Id));
		}
	}
}

