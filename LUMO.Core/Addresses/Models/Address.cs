using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Addresses
{
    public class Address
    {
        public int Id { get; set; }
        public string Line { get; set; }
        public City City { get; set; }
    }
}