using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class CategoryBrowsePage : ContentPage
	{
		public CategoryBrowsePage()
		{

			InitializeComponent();
			GetCategories();
		}

		async void GetCategories()
		{
			ObservableCollection<Category> categoryList = await App.AppService.GetCategories();
			list.ItemsSource = categoryList;
		}

		void OnItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var category = (Category)e.SelectedItem; // selected item'ın cat_id'sını öbür sayfaya gönder
			Navigation.PushAsync(new ItemBrowsePage(category.Id)); //cat_id'yi bunun içinde yolla
		}
	}
}