using System;
using Interface_Task.Helpers.Responses;
using Interface_Task.Models;

namespace Interface_Task.Services.Interfaces
{
	public interface IEmployeeService
	{
		public Employee[] GetAll();
		public EmployeeResponse GetById(Employee[]employees,int? id);
		public EmployeeResponse Search(Employee[]employees,string text); 
	}
}

