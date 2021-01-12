using System;
using System.Collections.Generic;
using System.Text;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{

    public class Rules_Tests
    {
        /* Notes: Structure of Rules
         * general file structure:  condition field, comparison (always, eq, ge, lt), value, result field, action (set, add, sub), value
         * initial rules:
         * 1 - none, always, none, interest_rate, set, value
         * 2 - state, eq, Florida, disqualified, set, true 
         * 3 - credit_score, ge, 720, interest_rate, sub, .3
         * 4 - credit_score, lt, 720, interest_rate, add, .5
         * 5 - name, eq, "7-1 ARM", interest_rate, add, .5
         * 
         */
        
        [Fact]
        public void Load_Success()
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
        }
    }
}
