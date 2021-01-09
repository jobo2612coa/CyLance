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
        public void Print_Result() {
            string expected = "product.name == Test\nproduct.interest_rate == 5.0\nproduct.disqualified == False\n\n";
            RulesEngine rulesEngine = new RulesEngine();
            string result = rulesEngine.runRules(new Person(720, "Florida"), new Product("Test", 5.0m), "null rules");
            Assert.Equal(result, expected);
        }
        public void Print_Output()
        {
            RulesEngine rulesEngine = new RulesEngine();

        }
    }
}
