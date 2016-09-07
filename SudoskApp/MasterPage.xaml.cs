using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage()
		{
			InitializeComponent();
			Title = "MasterPage";

			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Categories",
				TargetType = typeof(CategoryBrowsePage)
			});
		
			masterPageItems.Add(new MasterPageItem
			{
				Title = "My Equipments",
				TargetType = typeof(MyItems)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Change Password",
				TargetType = typeof(ChangePassword)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Admin",
				TargetType = typeof(AdminPage)
			});

			listView.ItemsSource = masterPageItems;
		}

	}
}

