using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestRules;

namespace XUnitTestProject1
{

    public class Rule_Tests
    {
        [Fact]
        public void Create()
        {
            Rule rule = new Rule("", "interest_rate", "set", "value");
            Assert.Equal("", rule.query);

            Assert.Equal("interest_rate", rule.action_field);
            Assert.Equal("set", rule.action_function);
            Assert.Equal("value", rule.action_value);
        }
    }
}
