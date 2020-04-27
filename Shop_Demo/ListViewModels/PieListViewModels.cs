using Shop_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_Demo.ListViewModels
{
    public class PieListViewModels
    {
        public IEnumerable<Pie> pies { get; set; }
        public String CurrentCategory { get; set; }
    }
}
