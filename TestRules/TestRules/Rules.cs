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
            rules.Clear();
            rules.Add(new Rule("always", "na", "na", "interest_rate", "set", "5.0"));
            rules.Add(new Rule("state", "eq", "Florida", "disqualifed", "set", "true"));
            rules.Add(new Rule("credit_score", "ge", "720", "interest_rate", "sub", ".3"));
            rules.Add(new Rule("credit_score", "lt", "720", "interest_rate", "add", ".5"));
            rules.Add(new Rule("state", "eq", "7-1 ARM", "interest_rate", "add", ".5"));
            return rules;
        }
        /* Notes: Structure of Rules
         * general structure:  condition field, comparison (eq, ge, lt), value, result field, action (set, add, sub), value
         * initial rules:
         * 1 - none, none, none, interest_rate, set, value
         * 2 - state, eq, Florida, disqualified, set, true 
         * 3 - credit_score, ge, 720, interest_rate, sub, .3
         * 4 - credit_score, lt, 720, interest_rate, add, .5
         * 5 - name, eq, "7-1 ARM", interest_rate, add, .5
         * 
         */
    }

    public class Rule
    {
        public string parameter_field { get; set; }
        public string comparison { get; set; }
        public string parameter_value { get; set; }
        public string result_field { get; set; }
        public string action { get; set; }
        public string action_value { get; set; }
        public Rule(string _parameter, string _comparison, string _parameter_value, string _action, string _result_field, string _action_value)
        {
            parameter_field = _parameter;
            comparison = _comparison;
            parameter_value = _parameter_value;
            result_field = _result_field;
            action = _action;
            action_value = _action_value;
        }
    }
}
