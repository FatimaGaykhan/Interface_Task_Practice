using System;
using Interface_Task.Models;

namespace Interface_Task.Helpers.Responses
{
	public class EmployeeResponse
	{
		public Employee Employee{ get; set; }
        public string ErrorMessage { get; set; }
		public Employee[] Employees { get; set; }

    }
}

