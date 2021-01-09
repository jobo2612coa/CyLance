using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class RulesEngine
    {
        public string runRules(Person person, Product product, string rules)
        {

            string output = String.Format("product.name == {0}\n", product.name);
            output += String.Format("product.interest_rate == {0}\n", product.interest_rate);
            output += String.Format("product.disqualified == {0}\n\n", product.disqualified);

            Console.WriteLine(output);
            return output;
        }


    }
}
