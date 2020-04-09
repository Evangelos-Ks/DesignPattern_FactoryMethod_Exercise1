using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exercise1
{
    class FactoryMethodPrint
    {
        public void Print(Page page)
        {
            if ( page.GetType() == typeof(BlackAndWhitePage) )
            {
                new PrintBlackAndWhite();
            }
            else if (page.GetType() == typeof(ColorfullPage))
            {
                new PrintColorfull();
            }
        }
    }
}
