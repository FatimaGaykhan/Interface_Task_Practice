﻿using System;
namespace Interface_Task.Models
{
	public class Employee:BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public DateTime Birthday { get; set; }

	}
}

