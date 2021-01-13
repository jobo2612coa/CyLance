using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestRules;

namespace XUnitTestProject1
{
    public class RulesEngine_Tests
    {
        [Fact]
        public void Exam_Testcase() {
            string expected = "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.2\nproduct.disqualified == True\n\n";
            RulesEngine rulesEngine = new RulesEngine();
            Rules rules = new Rules();
            rules.loadRules();


            Person person = new Person(720, "Florida");
            Product product = new Product("7 - 1 ARM", 5.0, false);

            string result = rulesEngine.runRules(person, product, rules.rules);
            Assert.Equal(result, expected);            
        }
        [Theory]
        [InlineData("", "interest_rate", "set", "5.0", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.0\nproduct.disqualified == False\n\n")]
        [InlineData("state = 'Florida'", "disqualified", "set", "true", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.0\nproduct.disqualified == True\n\n")]
        [InlineData("credit_score >= 720", "interest_rate", "sub", "0.3", "product.name == 7 - 1 ARM\nproduct.interest_rate == 4.7\nproduct.disqualified == False\n\n")]
        [InlineData("credit_score < 720", "interest_rate", "add", "0.5", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.0\nproduct.disqualified == False\n\n")]
        [InlineData("name = '7 - 1 ARM'", "interest_rate", "add", "0.5", "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.5\nproduct.disqualified == False\n\n")]
        public void Rate(string _query, string _field, string _function, string _value, string _expected)
        {
           // const string expected = "product.name == 7 - 1 ARM\nproduct.interest_rate == 5.5\nproduct.disqualified == False\n\n"; 

            Rules rules = new Rules();
            rules.loadRules();
            Rule rule = new Rule(_query, _field, _function, _value);
            string output = RateField.Rate(new Person(720, "Florida"), new Product("7 - 1 ARM", 5.0m, false), rule);
            Assert.Equal(_expected, output);
        }
    }
}
