using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_LABRAB_9.entities
{
    public class Product
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public bool IsStandard { get; set; }
        public string Note { get; set; }
        public int AnnualProductionVolume { get; set; }
    }

}
