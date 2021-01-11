using System;
using System.Collections.Generic;
using System.Text;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{

    public class Rules_Tests
    {
        [Fact]
        public void Create()
        {
            IList<Rule> rulesResult = new List<Rule>();
            try
            {
                Rules rules = new Rules();
                rulesResult = rules.loadRules();
                Assert.True(true);
            } catch
            {
                Assert.True(false);
            }

            //Rules newRules = rules.loadRules;

        }
    }
}
