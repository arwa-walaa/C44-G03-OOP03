using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {
        public TypeB()
        {
            // A = 10; // Not accessible, private
            B = 20; // Accessible, internal
            C = 30; // Accessible, public
            X = 40; // Accessible, private protected (accessible within the same assembly)
            Y = 50; // Accessible, protected (accessible in derived classes)
            Z = 60; // Accessible, protected internal (accessible in derived classes and within the same assembly)
        }
    }
}
