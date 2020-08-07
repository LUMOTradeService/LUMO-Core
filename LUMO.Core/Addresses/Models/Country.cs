using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Addresses
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public string ISOCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}