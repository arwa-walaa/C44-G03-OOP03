using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSsession3
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private decimal _salary;

        public int ID
        {
            get => _id;
            set => _id = value > 0 ? value
                : throw new ArgumentException("ID must be positive");
        }

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value.Trim()
                : throw new ArgumentException("Name cannot be empty");
        }

        public SecurityPrivilege SecurityLevel { get; set; }

        public decimal Salary
        {
            get => _salary;
            set => _salary = value >= 0 ? value
                : throw new ArgumentException("Salary cannot be negative");
        }

        public HiringDate HireDate { get; set; }
        public Gender EmployeeGender { get; set; }

        public Employee(int id, string name, SecurityPrivilege securityLevel,
                        decimal salary, HiringDate hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            EmployeeGender = gender;
        }

     
        public override string ToString()
        {
            return String.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                ID, Name, SecurityLevel, Salary, HireDate, EmployeeGender);
        }


    }
}
