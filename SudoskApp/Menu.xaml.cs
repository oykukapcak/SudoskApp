using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Menu : MasterDetailPage
	{
		MasterPage masterPage;
		public Menu()
		{
			masterPage = new MasterPage();
			Master = masterPage;
			Detail = new NavigationPage(new CategoryBrowsePage());
			masterPage.ListView.ItemSelected += OnItemSelected;
		}

		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}

