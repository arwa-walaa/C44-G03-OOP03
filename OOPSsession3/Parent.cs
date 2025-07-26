using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSsession3
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent CTOR");
        }

       

         public virtual int Multiply()
        {
            return X * Y;
        }
        public  void MyFunc()
        {
            Console.WriteLine("Parent Class");
        }

        public override string ToString()
        {
            return $" X: {X}, Y: {Y}";
        }

    }
}
