using System;
using System.Collections.Generic;
using System.Text;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{
    public class Product_Tests
    {
        [Theory]
        [InlineData("7 - 1 ARM", 5.0)]
        public void Create(string name, double interest_rate)
        {
            Product product = new Product(name, interest_rate, false);
            Assert.Equal(name, product.name);
            Assert.Equal(interest_rate.ToString(), product.interest_rate.ToString());
        }
    }
}
