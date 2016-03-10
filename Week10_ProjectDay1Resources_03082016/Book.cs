using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay1Resources_03082016
{
    class Book : Resource
    {
        //ViewTitle()
        public override void ViewTitle()
        {
            Console.WriteLine("VIEW BOOK TITLE");
            base.ViewTitle();
        }

        //AddTitle()
        public override void AddTitle()
        {
            Console.WriteLine("ADD BOOK TITLE");
            base.AddTitle();
        }

        //CheckOut()
        public override void CheckOut()
        {
            Console.WriteLine("CHECK OUT BOOK RESOURCE");
            this.StatusAvailable = false;
            PrintAvailable(this.Title);
            returnDate = DateTime.Now.AddDays(5).ToString("D");
            Console.WriteLine("{0} is due back on {1}.", this.Title, returnDate);
            PressKey();
        }

        //CheckIn()
        public override void CheckIn()
        {
            Console.WriteLine("CHECK IN BOOK RESOURCE");
            base.CheckIn();
        }
    }
}
