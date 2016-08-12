using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SudoskApp
{
	public partial class Menu : MasterDetailPage
	{
		
		public Menu()
		{
			Master = new MasterPage();
			Detail = new NavigationPage(new Equipments());
		}
	}
}

