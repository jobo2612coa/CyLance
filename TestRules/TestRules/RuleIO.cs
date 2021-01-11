using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;



namespace TestRules
{
    public class RuleIO
    {
        public void WriteJSON (string content)
        {
            string fileName = "TestRules.json";

            Rules rules = new Rules();
            rules.loadRules();

            string jsonString = JsonSerializer.Serialize(rules);
            System.IO.File.WriteAllText(fileName, jsonString);
        }
    }
}
