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
            Product product = new Product("7 - 1 ARM", 5.0);

            string result = rulesEngine.runRules(person, product, rules.rules);
            Assert.Equal(result, expected);
            
        }
        [Fact]
        public void Print_Output()
        {
            RulesEngine rulesEngine = new RulesEngine();

        }
    }
}
