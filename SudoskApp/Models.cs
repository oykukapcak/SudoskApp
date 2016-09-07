using System;
namespace SudoskApp
{

	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }
		public DateTime? BeginDate { get; set; }
		public DateTime? EndDate { get; set; }
		public int? EventId { get; set; }
		public int? UserId { get; set; }
	}


	public class RequestedItem
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public int EventId { get; set; }
		public int UserId { get; set; }
	}

	public class ConfirmedItem
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public int EventId { get; set; }
		public int UserId { get; set; }
	}

	public class BookedItem
	{
		public int Id { get; set; }
		public int ItemId { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public int EventId { get; set; }
		public int UserId { get; set; }
	}

	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Event
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class MemberRequest
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
	}

	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}

}

