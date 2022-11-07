using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForHW12
{
    class Disclaimer
    {
        public static void ShowDisclaimer()
        {
            string disclaimer1 = "!!Disclaimer!!";
            string disclaimer2 = "Все имена, персонажи и события являются вымышленными!";
            string disclaimer3 = "Любое совпадение с реальными людьми является случайным!";
            string disclaimer4 = "При написании кода ни один политик не пострадал!";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (disclaimer1.Length / 2)) + "}", disclaimer1));
            Thread.Sleep(1500);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (disclaimer2.Length / 2)) + "}", disclaimer2));
            Thread.Sleep(1500);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (disclaimer3.Length / 2)) + "}", disclaimer3));
            Thread.Sleep(1500);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (disclaimer4.Length / 2)) + "}", disclaimer4));
            Thread.Sleep(5000);
        }
    }
}
