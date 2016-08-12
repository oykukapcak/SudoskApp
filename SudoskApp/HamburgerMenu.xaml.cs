using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class HamburgerMenu : MasterDetailPage
	{
		
		public HamburgerMenu()
		{
			Master = new MasterPage();
			Detail = new NavigationPage(new Equipments());
			//InitializeComponent();
		}
	}
}

