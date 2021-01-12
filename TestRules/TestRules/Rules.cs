using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class Rules
    {
        public List<Rule> rules = new List<Rule>();
        public List<Rule> loadRules()
        {
            RuleIO ruleIO = new RuleIO();

            rules = ruleIO.ReadJSON();
            return rules;
        }
        public List<Rule> loadRule(Rule rule)
        {
            rules.Add(rule);
            return rules;
        }
        
        /* Notes: Structure of Rules
         * general structure:  condition field, comparison (always, eq, ge, lt), value, result field, action (set, add, sub), value
         * initial rules:
         * 1 - none, always, none, interest_rate, set, value
         * 2 - state, eq, Florida, disqualified, set, true 
         * 3 - credit_score, ge, 720, interest_rate, sub, .3
         * 4 - credit_score, lt, 720, interest_rate, add, .5
         * 5 - name, eq, "7-1 ARM", interest_rate, add, .5
         * 
         */
    }
}
