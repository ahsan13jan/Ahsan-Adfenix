using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Ahsan
{
    [Database]
    public class FranchiseTransaction
    {
        public Franchise Franchise { get; set; }
        public string Date { get; set; }
        public int SalesPrice { get; set; }
        public int Commission { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get { return String.Format("{0} {1}, {2} {3} , {4}", Street, Number, ZipCode, City, Country); } }
    }
}
