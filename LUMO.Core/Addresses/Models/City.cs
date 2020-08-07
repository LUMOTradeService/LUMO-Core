using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Addresses
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
    }
}