using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_LABRAB_9.entities
{
    public class Production
    {
        public int Year { get; set; }
        public int Volume { get; set; }

        public string ProductName { get; set; }

        public string EnterpriseName { get; set; }

        public int EnterpriseCode { get; set; }
        public int ProductCode { get; set; }

    }
}
