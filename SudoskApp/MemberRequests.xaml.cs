using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Plugin.Messaging;
using Xamarin.Forms;

namespace SudoskApp
{
	public partial class MemberRequests : ContentPage
	{
		public MemberRequests()
		{
			InitializeComponent();
			GetMemberRequests();
		}

		async void GetMemberRequests()
		{
			ObservableCollection<MemberRequest> memberList = await App.AppService.GetMemberRequests();
			list.ItemsSource = memberList;
		}

		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			await App.AppService.ConfirmMemberRequest(((User)e.SelectedItem).Id);
			SendEmail(((User)e.SelectedItem).Email);
		}

		void OnYesClicked(object sender, System.EventArgs e)
		{
		}

		void OnNoClicked(object sender, System.EventArgs e)
		{
		}

		void SendEmail(string adress)
		{ 
			string email_text = "Your member request has been confirmed.You can login with the following password, then change it./n" +
				"Pasword:12345/n/nThank you for using our app.";

			string email_subject = "Member request confirmation";
			var EmailTask = MessagingPlugin.EmailMessenger;

			if (EmailTask.CanSendEmail)
				EmailTask.SendEmail(adress, email_subject, email_text);

		}
	}
}

