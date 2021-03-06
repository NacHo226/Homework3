using System;
using Task1.User.Interfaces;

namespace Task1.User.Classes
{
    public class User : IDisplayable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal JobSalary { get; set; }
        public string FullName => ($"{FirstName} {LastName}");

        public virtual void Display()
        {
            Console.WriteLine($"Hello, I'm {FullName}.");
        }
    }
}