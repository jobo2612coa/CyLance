using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class Product
    {
        public string name { get; set; }
        public decimal interest_rate { get; set; }
        public Boolean disqualified { get; set; }

        public Product (string _name, decimal _interest_rate)
        {
            name = _name;
            interest_rate = _interest_rate;
        }
        public Product(string _name, double _interest_rate)
        {
            name = _name;
            interest_rate = Convert.ToDecimal(_interest_rate);
        }

    }
}
