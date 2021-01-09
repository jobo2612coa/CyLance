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
            RulesEngine rulesEngine = new RulesEngine();
            rulesEngine.runRules(new Person(720, "Florida"), new Product("Test", 5.0m), "null rules");
            Assert.True(true);
        }
    }
}
