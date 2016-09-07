using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class AdminPage : ContentPage
	{
		public AdminPage()
		{
			InitializeComponent();
		}

		void OnCategoryClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AddCategory());
		}

		void OnEquipmentClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AddEquipment());
		}

		void OnMemberReqsClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MemberRequests());
		}

		void OnBookedClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Booked());
		}

		void OnConfirmedClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Confirmed());
		}

		void OnRequestedClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Requested());
		}
	}
}

