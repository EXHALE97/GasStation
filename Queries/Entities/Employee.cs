using System;

namespace Queries.Entities
{
    public class Employee
    {
        public int Id { get; }
        public int CredId { get; }
        public string SurName { get; }
        public string Name { get; }
        public string MiddleName { get; }
        public string Position { get; }
        public DateTime Birthday { get; }
        public DateTime EmploymentDate { get; }
        public DateTime ContractEndDate { get; }
        public double Salary { get; }
        public string Address { get; }
        public string Phone { get; }
        public bool IsWorking { get; }

        public Employee(int id, int credId, string surName, string name, string middleName, string position,
            DateTime birthday, DateTime employmentDate, DateTime contractEndDate, double salary,
            string address, string phone, bool isWorking)
        {
            Id = id;
            CredId = credId;
            SurName = surName;
            Name = name;
            MiddleName = middleName;
            Position = position;
            Birthday = birthday;
            EmploymentDate = employmentDate;
            ContractEndDate = contractEndDate;
            Salary = salary;
            Address = address;
            Phone = phone;
            IsWorking = isWorking;
        }
    }
}
