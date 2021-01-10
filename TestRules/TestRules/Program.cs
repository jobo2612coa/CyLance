using System;
using System.Collections.Generic;

namespace TestRules
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(720, "Florida");
            Product product = new Product("7 - 1 ARM", 5.0);
            // instansiate rules engine
            RulesEngine rules_engine = new RulesEngine();

            // load rules
            Rules rules = new Rules();
            List<Rule> rulesResult = rules.loadRules();

            // run rules
            rules_engine.runRules(person, product, rulesResult);


            // running rules causes printed output
            // listing product fields
            // product.name == whatever
            // product.interest_rate == 5.2
            // product.disqualified == true


        }
    }
}
