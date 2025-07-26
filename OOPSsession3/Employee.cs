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
        private SecurityPrivilege _securityLevel;
        private decimal _salary;
        private string _hireDate;
        private Gender _gender;

        // Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public SecurityPrivilege SecurityLevel
        {
            get { return _securityLevel; }
            set { _securityLevel = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        public Gender EmployeeGender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        // Constructor
        public Employee(int id, string name, SecurityPrivilege securityLevel,
                        decimal salary, string hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            EmployeeGender = gender;
        }

        // Override ToString() method
        public override string ToString()
        {
            return String.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                ID, Name, SecurityLevel, Salary, HireDate, EmployeeGender);
        }


    }
}
