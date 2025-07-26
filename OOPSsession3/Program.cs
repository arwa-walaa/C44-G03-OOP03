namespace OOPSsession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region User Defiended Data Type[Class]
            //Car c1=new Car(1,"BMW",300);
            //Console.WriteLine(c1);

            //Car c2= new Car(2, "Audi");
            // Console.WriteLine(c2);

            //Car c3 = new Car(3);
            //Console.WriteLine(c3);


            #endregion

            #region Inheritance

            //Parent parent = new Parent(10, 20);

            //parent.X = 1;
            //parent.Y = 2;
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Multiply());
            //parent.MyFunc();


            Child child = new Child(10, 20, 30);
            child.X = 3;
            child.Y = 4;
            child.Z = 5;
            Console.WriteLine(child);
            Console.WriteLine(child.Multiply());
            child.MyFunc(); // Calls Child's MyFunc due to new keyword
            #endregion

        }
    }
}
