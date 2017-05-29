using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Ahsan
{

    [Database]
    public class Franchise
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Corporation Corporation;
        public string Name { get; set; }

        public int NumberOfHomesSold
        {
            get
            {
                try
                {
                    return (int)Db.SlowSQL<Int64>("SELECT COUNT(*) FROM FranchiseTransaction t WHERE Franchise = ?", this).First;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }
        public int TotalCommission
              {
            get
            {
                try {
                    return (int)Db.SlowSQL<Int64>("SELECT SUM(t.Commission) FROM FranchiseTransaction t WHERE Franchise = ?", this).First;
                }
                catch(Exception e)
                {
                    return 0;
                }
            }
        }
        public decimal AverageCommision
        {
            get
            {
                try
                {
                    return Db.SlowSQL<Decimal>("SELECT SUM(t.Commission)/COUNT(*) FROM FranchiseTransaction t WHERE Franchise = ?", this).First;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }
        public int Trend;

        public string Address { get { return String.Format("{0} {1}, {2} {3} , {4}", Street, Number, ZipCode, City, Country); } }
    }
}
