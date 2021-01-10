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
            Rule rule = new Rule("none", "none", "none", "interest_rate", "set", "value");
            Assert.Equal("none", rule.parameter_field);
            Assert.Equal("none", rule.comparison);
            Assert.Equal("none", rule.parameter_value);
            Assert.Equal("interest_rate", rule.result_field);
            Assert.Equal("set", rule.action);
            Assert.Equal("value", rule.action_value);
        }
    }
}
