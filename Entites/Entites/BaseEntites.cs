using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Entites
{
    public class BaseEntites
    {
        public int ID { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);


    }
}
