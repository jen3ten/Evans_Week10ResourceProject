using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay1Resources_03082016
{
    abstract class Resource         //The Resource base class is abstract; no objects of type Resource can be instantiated
    {
        //Fields
        private string title;
        private string isbn;
        private int length;
        private bool statusAvailable;
        protected string returnDate;

        //Properties
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Length { get; set; }
        public bool StatusAvailable { get; set; }

        //Constructor
        public Resource()
        {
            this.Title = "No title listed";
            this.ISBN = "978-99-99999-99-9";
            this.Length = 0;
            this.StatusAvailable = true;
        }

        //Methods
        //ViewTitle() prints out title, ISBN, length and status
        public virtual void ViewTitle()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Title:\t\t{0}", this.Title);
            Console.WriteLine("ISBN:\t\t{0}", this.ISBN);
            Console.WriteLine("# Pages:\t{0}", this.Length);
            PrintAvailable();
            Console.WriteLine("*************************************");
            Console.WriteLine();
            PressKey();
        }

        //AddTitle()
        public virtual void AddTitle()
        {
            Console.Write("What is the name of the resource? ");
            this.Title = Console.ReadLine();
            Console.Write("What is the ISBN of this resource? ");
            this.ISBN = Console.ReadLine();
            Console.Write("How many pages does the resource have? ");
            this.Length = int.Parse(Console.ReadLine());
            PrintAvailable();
            PressKey();
        }

        //CheckOut()
        public virtual void CheckOut()
        {
            this.StatusAvailable = false;
            PrintAvailable(this.Title);
            returnDate = DateTime.Now.AddDays(3).ToString("D");
            Console.WriteLine("{0} is due back on {1}.", this.Title, returnDate);
            PressKey();
        }

        //CheckIn()
        public virtual void CheckIn()
        {
            this.StatusAvailable = true;
            PrintAvailable(this.Title);
            PressKey();
        }

        //PrintAvailable()
        public void PrintAvailable()
        {
            if (StatusAvailable)
                Console.WriteLine("This resource is available.");
            else
                Console.WriteLine("This resource has been checked out.");
        }

        //PrintAvailable()
        public void PrintAvailable(string title)
        {
            if (StatusAvailable)
                Console.WriteLine("{0} is available.", title);
            else
                Console.WriteLine("{0} has been checked out.", title);
        }

        //PressKey()
        public void PressKey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
