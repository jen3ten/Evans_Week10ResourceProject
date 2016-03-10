using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay1Resources_03082016
{
    class Magazine : Resource
    {
        //ViewTitle()
        public override void ViewTitle()
        {
            Console.WriteLine("VIEW MAGAZINE TITLE");
            base.ViewTitle();
        }

        //AddTitle()
        public override void AddTitle()
        {
            Console.WriteLine("ADD MAGAZINE TITLE");
            base.AddTitle();
        }

        //CheckOut()
        public override void CheckOut()
        {
            Console.WriteLine("CHECK OUT MAGAZINE RESOURCE");
            this.StatusAvailable = false;
            PrintAvailable(this.Title);
            returnDate = DateTime.Now.AddDays(2).ToString("D");
            Console.WriteLine("{0} is due back on {1}.", this.Title, returnDate);

            PressKey();
        }

        //CheckIn()
        public override void CheckIn()
        {
            Console.WriteLine("CHECK IN MAGAZINE RESOURCE");
            base.CheckIn();
        }
    }
}
