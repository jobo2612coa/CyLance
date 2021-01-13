using System;
using System.Collections.Generic;
using System.Text;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{
   
    public class EndToEnd_Tests
    {
        [Theory]
        [InlineData("ID1", 720, "Florida", "7 - 1 ARM", 5.0,    "", "interest_rate", "set", "5.5",       "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.5\nproduct.disqualified == False\n\n")]
        [InlineData("ID2", 720, "Florida", "7 - 1 ARM", 5.0,    "state = 'Florida'", "disqualified", "set", "true",   "product.name == 7 - 1 ARM\nproduct.interest_rate == 5\nproduct.disqualified == True\n\n")]
        [InlineData("ID3", 720, "Texas", "7 - 1 ARM", 5.0,      "state = 'Florida'", "disqualified", "set", "true", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5\nproduct.disqualified == False\n\n")]
        [InlineData("ID4", 720, "Florida", "7 - 1 ARM", 5.0, "credit_score >= 720", "interest_rate", "sub", ".3",    "product.name == 7 - 1 ARM\nproduct.interest_rate == 4.7\nproduct.disqualified == False\n\n")]
        [InlineData("ID5", 710, "Florida", "7 - 1 ARM", 5.0, "credit_score >= 720", "interest_rate", "sub", ".3", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5\nproduct.disqualified == False\n\n")]
        [InlineData("ID6", 700, "Florida", "7 - 1 ARM", 5.0, "credit_score < 720", "interest_rate", "add", ".5", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.5\nproduct.disqualified == False\n\n")]
        [InlineData("ID7", 720, "Florida", "7 - 1 ARM", 5.0, "name = '7 - 1 ARM'", "interest_rate", "add", ".5", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.5\nproduct.disqualified == False\n\n")]
        [InlineData("ID8", 720, "Florida", "5YR BAL", 3.25, "name = '7 - 1 ARM'", "interest_rate", "add", ".5", "product.name == 5YR BAL\nproduct.interest_rate == 3.25\nproduct.disqualified == False\n\n")]
        [InlineData("ID9", 740, "Texas", "5YR BALLOON", 3.25, "state = 'Florida' or state = 'Texas'", "disqualified", "set", "true", "product.name == 5YR BALLOON\nproduct.interest_rate == 3.25\nproduct.disqualified == True\n\n")]
        [InlineData("IDA", 710, "Louisiana", "5YR BALLOON", 3.25, "state = 'Florida' or state = 'Texas'", "disqualified", "set", "true", "product.name == 5YR BALLOON\nproduct.interest_rate == 3.25\nproduct.disqualified == False\n\n")]
        [InlineData("IDB", 710, "Louisiana", "5YR BALLOON", 3.25, "credit_score <= 720", "interest_rate", "add", ".5", "product.name == 5YR BALLOON\nproduct.interest_rate == 3.75\nproduct.disqualified == False\n\n")]
        public static void RunRules(string _Test_ID, int _person_credit_score, string _person_state, string _product_name, decimal _product_interest_rate, string _r1, string _r2, string _r3, string _r4, string _expected)
        {
            Person person = new Person(_person_credit_score, _person_state);
            Product product = new Product(_product_name, _product_interest_rate, false);
            // instansiate rules engine
            RulesEngine rules_engine = new RulesEngine();

            // load rules
            Rules rules = new Rules();
            rules.loadRule(new Rule(_r1, _r2, _r3, _r4));

            // run rules
            string result = rules_engine.runRules(person, product, rules.rules);
            Assert.Equal(_expected, result);
        }
    }
}
