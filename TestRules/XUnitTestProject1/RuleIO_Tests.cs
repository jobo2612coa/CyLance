using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TestRules;

namespace XUnitTestProject1
{
    public class RuleIO_Tests
    {
        [Fact]
        public static void Write_JSON()
        {
            RuleIO ruleio = new RuleIO();
            ruleio.WriteInputJSON();
            Assert.True(true);
        }
        [Fact]
        public static void Read_JSON()
        {
            RuleIO ruleio = new RuleIO();
            ruleio.ReadJSON();
            Assert.True(true);
        }
    }
}
