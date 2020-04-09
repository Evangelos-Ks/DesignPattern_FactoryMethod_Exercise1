using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exercise1
{
    abstract class Print
    {
        public Printer Printer { get; set; }


        public Print()
        {
            this.Printer = SelectPrinter();
        }

        protected abstract Printer SelectPrinter();
    }

    class PrintBlackAndWhite : Print
    {
        protected override Printer SelectPrinter()
        {
            return new LaserPrinter();
        }
    }

    class PrintColorfull : Print
    {
        protected override Printer SelectPrinter()
        {
            return new InkPrinter();
        }
    }
}
