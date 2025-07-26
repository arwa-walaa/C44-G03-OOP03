namespace OOPSsession3
{

    [Flags]
    public enum SecurityPrivilege
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
     
    }

  
    public enum Gender
    {
        Male,   
        Female  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Design and implement a Class for the employees in a company

            //HiringDate hireDate = new HiringDate(12,12, 2023);

            //Employee emp = new Employee(
            //       101,
            //       "Arwa",
            //       SecurityPrivilege.Developer,
            //       75000.50m,
            //      "12\12\2023",
            //       Gender.Male);


            //Console.WriteLine(emp);


            #endregion

            #region 2. Develop a Class to represent the Hiring Date Data:

            //HiringDate hireDate = new HiringDate(12, 12, 2023);

            //Employee emp = new Employee(
            //       101,
            //       "Arwa",
            //       SecurityPrivilege.Developer,
            //       75000.50m,
            //       hireDate,
            //       Gender.Male);


            //Console.WriteLine(emp);
            #endregion

            #region 3. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            Employee[] EmpArr = new Employee[3];
            // Create DBA
            EmpArr[0] = new Employee(
                101,
                "Arwa",
                SecurityPrivilege.DBA,
                95000m,
                new HiringDate(15, 6, 2023),
                Gender.Female);

            // Create Guest
            EmpArr[1] = new Employee(
                102,
                "Sara",
                SecurityPrivilege.Guest,
                45000m,
                new HiringDate(1, 12, 2022),
                Gender.Female);

            // Create Security Officer with full permissions
            EmpArr[2] = new Employee(
                103,
                "Ali",
                SecurityPrivilege.Guest | SecurityPrivilege.Developer |
    SecurityPrivilege.Secretary | SecurityPrivilege.DBA,
                110000m,
                new HiringDate(10, 3, 2015),
                Gender.Male);

            // Display all employees
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("-------------------");
            //}

            #endregion

            #region 4. Sort the employees based on their hire date then Print the sorted array
            var sortedEmployees = EmpArr.OrderBy(e => e.HireDate.ToDateTime()).ToArray();

            // Print sorted employees
            Console.WriteLine("Employees sorted by hire date:");
          
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine(emp);
                
                Console.WriteLine("----------------------------");
            }
            //no boxing or unboxing occurs

            #endregion

         

        }
    }
}
