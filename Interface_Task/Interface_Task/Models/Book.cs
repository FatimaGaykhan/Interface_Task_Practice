using System;
namespace Interface_Task.Models
{
	public class Book:BaseEntity
	{
		public string Name { get; set; }
		public Author Author { get; set; }

	}
}

