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

            Employee emp = new Employee(
                   101,
                   "Arwa",
                   SecurityPrivilege.Developer,
                   75000.50m,
                   "2020, 5, 15",
                   Gender.Male);

           
            Console.WriteLine(emp);
          

            #endregion

        }
    }
}
