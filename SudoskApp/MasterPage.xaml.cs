using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();
			Title = "MasterPage";
		}

		void onBookingClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new Booking());
		}
	}
}

