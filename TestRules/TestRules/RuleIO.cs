using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;



namespace TestRules
{

    public class RuleIO
    {
        const string fileName = "TestRules.json";
        public void WriteJSON (string content)
        {

            Rules rules = new Rules();
            rules.loadRules();
            List<Rule> listRule = rules.rules;


            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string jsonStringRule = null;
            foreach ( Rule rule in listRule)
            {
                 jsonStringRule += JsonSerializer.Serialize(rule);
            }
                System.IO.File.WriteAllText(fileName, jsonStringRule);
          




        }
        public List<Rule> ReadJSON()
        {
            Rules result = new Rules();
            string JSONstring = System.IO.File.ReadAllText(fileName);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            result.rules = JsonSerializer.Deserialize<List<Rule>>(JSONstring, options);
            return result.rules;

        }

        public void WriteInputJSON() // one time use
        {

            Rules rules = new Rules();
            rules.rules.Clear();
            // format of the rules is:
            //    if   <first item field to test>
            //    is   <second item conditional>
            //         <third item compare value>
            //    then <fourth item field to change>
            //         <fifth item action to take>
            //         <sixth item value to use>
            rules.rules.Add(new Rule("", "interest_rate", "set", "5.0"));
            rules.rules.Add(new Rule("state = 'Florida'", "disqualified", "set", "true"));
            rules.rules.Add(new Rule("credit_score >= 720", "interest_rate", "sub", ".3"));
            rules.rules.Add(new Rule("credit_score < 720", "interest_rate", "add", ".5"));
            rules.rules.Add(new Rule("name = '7 - 1 ARM'", "interest_rate", "add", ".5"));
            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string jsonStringRule = JsonSerializer.Serialize(rules.rules, options);
            System.IO.File.WriteAllText(fileName, jsonStringRule);
        }
    }
}
