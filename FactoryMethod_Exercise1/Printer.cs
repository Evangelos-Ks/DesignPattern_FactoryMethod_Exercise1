using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exercise1
{
    abstract class Printer
    {
        protected List<Page> pages = new List<Page>();

        protected abstract void PrintMethod();
    }

    class LaserPrinter : Printer
    {
        public LaserPrinter()
        {
            PrintMethod();
        }

        protected override void PrintMethod()
        {
            pages.Add(new BlackAndWhitePage());
            Console.WriteLine("I'm the laser printer and I will print black and white pages");
            for (int i = 0; i < pages.Count; i++)
            {
                Console.WriteLine(pages[i].TextPage);
            }
        }
    }

    class InkPrinter : Printer
    {
        public InkPrinter()
        {
            PrintMethod();
        }

        protected override void PrintMethod()
        {
            pages.Add(new ColorfullPage());
            Console.WriteLine("I'm the ink printer and I will print colorfull pages");
            for (int i = 0; i < pages.Count; i++)
            {
                Console.WriteLine(pages[i].TextPage);
            }
        }
    }
}
