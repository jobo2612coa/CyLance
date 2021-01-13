using System;
using System.Collections.Generic;
using System.Text;


namespace TestRules
{
    public class Rule
    {
        public string query { get; set; }
        public string action_field { get; set; }
        public string action_function { get; set; }
        public string action_value { get; set; }
        public Rule() { }
        public Rule(string _query, string _action_field, string _action_function, string _action_value)
        {
            query = _query;
            action_field = _action_field;
            action_function = _action_function;
            action_value = _action_value;
        }
    }
}
