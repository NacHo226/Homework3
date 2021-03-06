using System;
using Bogus;

namespace Task1.User.Classes.Employee
{
    public class Employee : User
    {
        public Company company;

        public Employee()
        {
            GenerateCompany();
        }

        private void GenerateCompany()
        {
            var faker = new Faker<Company>("en")
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Country, f => f.Address.Country())
                .RuleFor(c => c.City, f => f.Address.City())
                .RuleFor(c => c.Address, f => f.Address.StreetAddress());

            company = faker.Generate();
        }

        public override void Display()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in \"{company.Name}\" ({company.Country}, {company.City}, {company.Address}) and my salary ${JobSalary}.");
        }
    }
}