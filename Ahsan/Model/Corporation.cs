using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starcounter;

namespace Ahsan
{

    [Database]
    public class Corporation
    {
        public string Name { get; set; }
        public QueryResultRows<Franchise> FranchiseList => Db.SQL<Franchise>("SELECT f FROM Franchise f WHERE f.Corporation = ?", this);

    }
}
