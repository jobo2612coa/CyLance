using System;
using System.Collections.Generic;
using System.Text;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{
    public class Main_Tests
    {
        [Fact]
        public static void Main_ish()
        {
            string expected = "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.2\nproduct.disqualified == True\n\n";
            Person person = new Person(720, "Florida");
            Product product = new Product("7 - 1 ARM", 5.0, false);
            // instansiate rules engine
            RulesEngine rules_engine = new RulesEngine();

            // load rules
            Rules rules = new Rules();
            List<Rule> rulesResult = rules.loadRules();

            // run rules
            string result = rules_engine.runRules(person, product, rulesResult);

            Assert.Equal(expected, result);
        }
    }
}
