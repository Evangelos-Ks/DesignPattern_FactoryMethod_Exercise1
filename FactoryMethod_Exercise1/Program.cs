using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodPrint printPage = new FactoryMethodPrint();
            printPage.Print(new ColorfullPage());
            Console.WriteLine();
            printPage.Print(new BlackAndWhitePage());
            Console.WriteLine();
            
        }
    }
}
