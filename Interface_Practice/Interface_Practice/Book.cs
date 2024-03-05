using System;
namespace Interface_Practice
{
    public class Book : IBook
    {
        public object MyProperty { get;set; }

        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public void GetName()
        {
            Console.WriteLine("Isgendername");
        }
    }
}

