using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class Rules
    {

        IList<Rule> rules = new List<Rule>();
        public List<Rule> loadRules()
        {
            List<Rule> result = new List<Rule>();
            result.Add(new Rule("interest_rate", "starts", "5.0"));
            result.Add(new Rule("state", "Florida", "disqualify"));
           
            IDictionary<string, Rule> dict1 = new Dictionary<string, Rule>();
            dict1.Add("interest_rate", new Rule("interest_rate", "starts", "5.0"));
            dict1.Add("state", new Rule("state", "Florida", "disqualify"));
            return result;
        }
    }

    public class Rule
    {
        public string parameter { get; set; }
        public string condition { get; set; }
        public string action { get; set; }
        public Rule(string _parameter, string _condition, string _action)
        {
            parameter = _parameter;
            condition = _condition;
            action = _action;
        }
    }
}
