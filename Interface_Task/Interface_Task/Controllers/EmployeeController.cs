using System;
using Interface_Task.Models;
using Interface_Task.Services;
using Interface_Task.Services.Interfaces;

namespace Interface_Task.Controllers
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;
		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}

		public void GetAll()
		{
			Employee[] employees = _employeeService.GetAll();

			foreach (var employee in employees)
			{
				Console.WriteLine($"{employee.Name} {employee.Surname} {employee.Age} {employee.Email} {employee.Address} {employee.Birthday.ToString("MM-dd-yyyy")}");
			}
		}

		public void GetById()
		{
			int? id = 100;
			var response = _employeeService.GetById(_employeeService.GetAll(),id);
			if (response.ErrorMessage is null)
			{
                 Console.WriteLine($"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Age} {response.Employee.Email} {response.Employee.Address} {response.Employee.Birthday.ToString("MM-dd-yyyy")}");

			}
			else
			{
				Console.WriteLine(response.ErrorMessage);
			}
        }

		public void Search()
		{
			string text = "sa";
			Employee[] employees = _employeeService.GetAll();
			var response = _employeeService.Search(employees, text);

			if (response.ErrorMessage is null)
			{
				foreach (var item in response.Employees)
				{
                    Console.WriteLine($"{item.Name} {item.Surname}");
                }

			}
			else
			{
				Console.WriteLine(response.ErrorMessage);
			}
			
		}
	}
}

