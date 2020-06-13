using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPart1
{
    interface IProduct
    {
        double Price { get; set; }
        DateTime Date { get; set; }
    }
}
