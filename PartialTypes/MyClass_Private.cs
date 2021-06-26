using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
    public partial class MyClass
    {
        // Private data field
        private double _length;
        private double _width;
        private double GetArea()
        {
            return _length * _width;
        }

        // All private helper members.
        public void Display()
        {
            Console.WriteLine("The length is: {0}", _length);
            Console.WriteLine("The width is: {0}", _width);
            Console.WriteLine("The area is: {0}", GetArea());
        }
    }
}
