using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Entites
{
    public class Product: BaseEntites
    {
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
