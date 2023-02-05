using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparesion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculatelength length_One = new Calculatelength(1,2,3,4);
            double length = length_One.Calculate();

            //UC2
            Calculatelength length_Two = new Calculatelength(3, 5, 6, 8);
            double length_ = length_Two.Calculate();

            if (length.Equals(length_))
                Console.WriteLine("Both line are equal");
            else
                Console.WriteLine("Both lines are not equal");

            //UC3
            if (length.CompareTo(length_) == 0)
                Console.WriteLine("Equal");
            else if (length.CompareTo(length_) > 0)
                Console.WriteLine("Line one is greater");
            else
                Console.WriteLine("Line two is greater");

            Console.ReadLine();
        }
    }
}
