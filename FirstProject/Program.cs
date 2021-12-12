using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter monthly oil bill: ");
            int averageMonthlyOilBill = Convert.ToInt32(Console.ReadLine());
            firstMethod(averageMonthlyOilBill);
        }
        static void firstMethod(int oilBill)
        {
            int yearlyOilBill = oilBill * 12;
            Console.WriteLine("Average yearly oil bill is: " + yearlyOilBill);
            Console.ReadLine();
        }
    }
}
