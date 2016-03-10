using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay1Resources_03082016
{
    class DVD : Resource
    {
        //ViewTitle() prints title, ISBN and length of DVD in minutes
        public override void ViewTitle()
        {
            Console.Clear();
            Console.WriteLine("VIEW DVD TITLE");
            Console.WriteLine("*************************************");
            Console.WriteLine("Title:\t\t{0}", this.Title);
            Console.WriteLine("ISBN:\t\t{0}", this.ISBN);
            Console.WriteLine("# Minutes:\t{0}", this.Length);
            PrintAvailable();
            Console.WriteLine("*************************************");
            Console.WriteLine();
            PressKey();
        }

        //AddTitle()
        public override void AddTitle()
        {
            Console.WriteLine("ADD DVD TITLE");
            Console.Write("What is the name of the resource? ");
            this.Title = Console.ReadLine();
            Console.Write("What is the ISBN of this resource? ");
            this.ISBN = Console.ReadLine();
            Console.Write("What is the length of the DVD in minutes? ");
            this.Length = int.Parse(Console.ReadLine());
            PrintAvailable();
            PressKey();
        }

        //CheckoutResource()
        public override void CheckOut()
        {
            Console.WriteLine("CHECK OUT DVD RESOURCE");
            base.CheckOut();
        }

        //CheckIn()
        public override void CheckIn()
        {
            Console.WriteLine("CHECK IN DVD RESOURCE");
            base.CheckIn();
        }
    }
}
