using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ProjectDay1Resources_03082016
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD dvdResource = new DVD();
            dvdResource.ViewTitle();
            dvdResource.AddTitle();
            dvdResource.ViewTitle();
            dvdResource.CheckOut();
            dvdResource.ViewTitle();
            dvdResource.CheckIn();
            dvdResource.ViewTitle();

            Book bookResource = new Book();
            bookResource.ViewTitle();
            bookResource.AddTitle();
            bookResource.ViewTitle();
            bookResource.CheckOut();
            bookResource.ViewTitle();
            bookResource.CheckIn();
            bookResource.ViewTitle();

            Magazine magResource = new Magazine();
            magResource.ViewTitle();
            magResource.AddTitle();
            magResource.ViewTitle();
            magResource.CheckOut();
            magResource.ViewTitle();
            magResource.CheckIn();
            magResource.ViewTitle();
        }
    }
}
