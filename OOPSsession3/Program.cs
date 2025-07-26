namespace OOPSsession3
{

    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    // Enum for gender
    public enum Gender
    {
        Male,   // Represents 'M'
        Female  // Represents 'F'
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Design and implement a Class for the employees in a company

            HiringDate hireDate = new HiringDate(12,12, 2023);

            Employee emp = new Employee(
                   101,
                   "Arwa",
                   SecurityPrivilege.Developer,
                   75000.50m,
                   hireDate,
                   Gender.Male);

           
            Console.WriteLine(emp);
          

            #endregion

        }
    }
}
