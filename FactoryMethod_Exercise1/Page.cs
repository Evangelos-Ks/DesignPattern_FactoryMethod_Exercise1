using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exercise1
{
    abstract class Page
    {
        public abstract string TextPage { get; }
        protected abstract Type TypeOfPage();
        protected abstract string Text();
    }

    class BlackAndWhitePage : Page
    {
        public override string TextPage { get; }

        public BlackAndWhitePage()
        {
            this.TextPage = Text();
        }

        protected override Type TypeOfPage()
        {
            return typeof(BlackAndWhitePage);
        }

        protected override string Text()
        {
            return "I'm an black and white page.";
        }
    }

    class ColorfullPage : Page
    {
        public override string TextPage { get; }

        public ColorfullPage()
        {
            this.TextPage = Text();
        }

        protected override Type TypeOfPage()
        {
            return typeof(ColorfullPage);
        }

        protected override string Text()
        {
            return "I'm a colorfull page.";
        }
    }
}


