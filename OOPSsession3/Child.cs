using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSsession3
{
    internal class Child : Parent
    {
         
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Child CTOR");
        }

        public override string ToString()
        {
            return $"X : {X} ,Y : {Y} , Z : {Z}";
        }
        public override int Multiply()
        {
           return base.Multiply() * Z;
        }
        //new => create new version of the method 
        public new void MyFunc()
        {
            Console.WriteLine("Child Class");
        }
    }
}
