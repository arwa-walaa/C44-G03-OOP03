using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeC
    {
        TypeB typeB= new TypeB();

        public TypeC()
        {
            // typeB.A = 10; // Not accessible, private
            typeB.B = 20; // Accessible, internal
            typeB.C = 30; // Accessible, public
            // typeB.X = 40; // Not accessible, private protected (accessible within the same assembly)
            // typeB.Y = 50; // Not accessible, protected (accessible in derived classes)
            // typeB.Z = 60; // Not accessible, protected internal (accessible in derived classes and within the same assembly)
        }
    }
}
