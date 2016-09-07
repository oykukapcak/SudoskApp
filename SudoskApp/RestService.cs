using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace SudoskApp
{
	public class RestService
	{
		HttpClient client;

		public RestService()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("http://sudoskapp.azurewebsites.net/sudosk/");
		}

		public async Task<ObservableCollection<Item>> GetItemsByCategoryId(int id)
		{

			ObservableCollection<Item> itemList = new ObservableCollection<Item>();

			var response = await client.GetAsync("getitemsbycat?categoryId=" + id);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				itemList = JsonConvert.DeserializeObject<ObservableCollection<Item>>(content);
			}

			return itemList;
		}

		public async Task<Item> GetItemById(int id)
		{
			Item myItem = new Item();
			var response = await client.GetAsync("getitem?itemId=" + id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				myItem = JsonConvert.DeserializeObject<Item>(content);
			}

			return myItem;
		}

		public async Task<ObservableCollection<Item>> GetItemsByUser(int user_id)
		{
			ObservableCollection<Item> bookedItemList = new ObservableCollection<Item>();
			var response = await client.GetAsync("getitemsbyuser?userId=" + user_id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				bookedItemList = JsonConvert.DeserializeObject<ObservableCollection<Item>>(content);
			}

			return bookedItemList;
		}

		public async Task<Event> GetEventById(int id)
		{
			Event myEvent = new Event();
			var response = await client.GetAsync("getevent?eventId=" + id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				myEvent = JsonConvert.DeserializeObject<Event>(content);
			}

			return myEvent;	
		}
		public async Task<ObservableCollection<Event>> GetEvents()
		{ 
				ObservableCollection<Event> eventList = new ObservableCollection<Event>();
				var response = await client.GetAsync("getevents");

				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					eventList = JsonConvert.DeserializeObject<ObservableCollection<Event>>(content);
				}

				return eventList;
		}

		public async Task<ObservableCollection<Category>> GetCategories()
		{
			ObservableCollection<Category> categoryList = new ObservableCollection<Category>();
			var response = await client.GetAsync("getcategories");

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				categoryList = JsonConvert.DeserializeObject<ObservableCollection<Category>>(content);
			}

			return categoryList;
		}

		public async Task Request(int item_id, DateTime begin_date, DateTime end_date, int event_id, int user_id)
		{ 
			 await client.GetAsync("onrequest?itemId=" + item_id + "&beginDate=" + begin_date + "&endDate=" + end_date + "&eventId=" + event_id + "&userId=" + user_id);
		}

		public async Task Confirm(int item_id)
		{ 
			await client.GetAsync("onconfirm?itemId=" + item_id);
		}

		public async Task Deliver(int item_id)
		{ 
			await client.GetAsync("ondeliver?itemId=" + item_id);
		}

		public async Task Book(int item_id)
		{ 
			await client.GetAsync("onbook?itemId=" + item_id);
		}


		public async Task<ObservableCollection<BookedItem>> GetBookedItems()
		{
 			ObservableCollection<BookedItem> bookedItemList = new ObservableCollection<BookedItem>();
			var response = await client.GetAsync("getbookeditems");

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				bookedItemList = JsonConvert.DeserializeObject<ObservableCollection<BookedItem>>(content);
			}

			return bookedItemList;
		}

		public async Task<ObservableCollection<RequestedItem>> GetRequestedItems()
		{
 			ObservableCollection<RequestedItem> requestedItemList = new ObservableCollection<RequestedItem>();
			var response = await client.GetAsync("getrequesteditems");

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				requestedItemList = JsonConvert.DeserializeObject<ObservableCollection<RequestedItem>>(content);
			}

			return requestedItemList;
		}

		public async Task<ObservableCollection<ConfirmedItem>> GetConfirmedItems()
		{
 			ObservableCollection<ConfirmedItem> confirmedItemList = new ObservableCollection<ConfirmedItem>();
			var response = await client.GetAsync("getconfirmeditems");

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				confirmedItemList = JsonConvert.DeserializeObject<ObservableCollection<ConfirmedItem>>(content);
			}

			return confirmedItemList;
		}

		public async Task<ObservableCollection<BookedItem>> GetBookedItemsByUser(int user_id)
		{
 			ObservableCollection<BookedItem> bookedItemList = new ObservableCollection<BookedItem>();
			var response = await client.GetAsync("getbookeditems?userId=" + user_id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				bookedItemList = JsonConvert.DeserializeObject<ObservableCollection<BookedItem>>(content);
			}

			return bookedItemList;
		}

		public async Task<ObservableCollection<RequestedItem>> GetRequestedItemsByUser(int user_id)
		{
 			ObservableCollection<RequestedItem> requestedItemList = new ObservableCollection<RequestedItem>();
			var response = await client.GetAsync("getrequesteditems?userId=" + user_id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				requestedItemList = JsonConvert.DeserializeObject<ObservableCollection<RequestedItem>>(content);
			}

			return requestedItemList;
		}

		public async Task<ObservableCollection<ConfirmedItem>> GetConfirmedItemsByUser(int user_id)
		{
 			ObservableCollection<ConfirmedItem> confirmedItemList = new ObservableCollection<ConfirmedItem>();
			var response = await client.GetAsync("getconfirmeditems?userId=" + user_id);

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				confirmedItemList = JsonConvert.DeserializeObject<ObservableCollection<ConfirmedItem>>(content);
			}

			return confirmedItemList;
		}

		public async Task<ObservableCollection<MemberRequest>> GetMemberRequests()
		{
 			ObservableCollection<MemberRequest> memberRequestsList = new ObservableCollection<MemberRequest>();
			var response = await client.GetAsync("getmemberrequests");

			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				memberRequestsList = JsonConvert.DeserializeObject<ObservableCollection<MemberRequest>>(content);
			}

			return memberRequestsList;
		}

		public async Task AddMemberRequest(string userName, string userSurname, string userEmail)
		{
			await client.GetAsync("addmemberrequest?name=" + userName + "&surname=" + userSurname + "&email=" + userEmail);
		}

		public async Task ConfirmMemberRequest(int userId)
		{ 
			await client.GetAsync("onbook?userId=" + userId);
		}

		public async Task AddItem(string name, string categoryId, string description)
		{
			await client.GetAsync("additem?name=" + name + "&categoryId=" + categoryId + "&description=" + description);
		}

		public async Task AddCategory(string name)
		{
			await client.GetAsync("addcategory?name=" + name);
		}


	}
}

