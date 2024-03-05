using System;
namespace Interface_Practice
{
	public interface IBook
	{
		public object MyProperty { get; set; }

		void GetName();
		int GetAge();
	}
}

