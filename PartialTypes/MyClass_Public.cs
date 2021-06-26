using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTypes
{
    public partial class MyClass
    {
        // Constructors.
        public MyClass(double length, double width)
        {
            _length = length;
            _width = width;
        }

        // All public members.
        public double CostCalculation()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void ShowInformation()
        {
            Display();
            Console.WriteLine("Costs: {0}", CostCalculation());
        }
    }
}
