using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class RulesEngine
    {
        public void runRules(Person person, Product product, string rules)
        {
            product.name = "Test Product Name";
            product.interest_rate = 5.0m;
            product.disqualified = false;

            listOutput(product);

        }

        private void listOutput(Product product)
        {
            // product.name == whatever
            // product.interest_rate == 5.2
            // product.disqualified == true
            Console.WriteLine("product.name == {0}", product.name);
            Console.WriteLine("product.interest_rate == {0}", product.interest_rate);
            Console.WriteLine("product.disqualified == {0}", product.disqualified);
        }
    }
}
