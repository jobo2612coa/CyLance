using System;
using System.Collections.Generic;
using System.Text;


namespace TestRules
{
    public class Rule
    {
        public string parameter_field { get; set; }
        public string comparison { get; set; }
        public string parameter_value { get; set; }
        public string result_field { get; set; }
        public string action { get; set; }
        public string action_value { get; set; }
        public Rule() { }
        public Rule(string _parameter, string _comparison, string _parameter_value, string _result_field, string _action, string _action_value)
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
