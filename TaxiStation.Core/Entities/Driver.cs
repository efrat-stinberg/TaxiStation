using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Core.Entities
{
    public class Driver
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }

        public string City { get; set; }

        public string CurrentPlace { get; set; }

    }
}
