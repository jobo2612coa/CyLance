using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class RulesEngine
    {
        public string runRules(Person person, Product product, IList<Rule> rules)
        {
            foreach (Rule rule in rules)
            {

                switch (rule.parameter_field)
                {
                    case "na":
                        if (EvalField.None(rule.comparison, rule.parameter_value)) 
                        {
                            switch (rule.result_field)
                            {
                                case "interest_rate":
                                    SetField.Interest_Rate(rule.action, Convert.ToDecimal(rule.action_value), product);
                                    break;
                                case "disqualified":
                                    SetField.Disqualified(rule.action, rule.action_value, product);
                                    break;
                            }
                        }
                        break;
                        
                    case "state":
                        if (EvalField.State(rule.comparison, rule.parameter_value, person))
                        {
                            switch (rule.result_field)
                            {
                                case "interest_rate":
                                    SetField.Interest_Rate(rule.action, Convert.ToDecimal(rule.action_value), product);
                                    break;
                                case "disqualified":
                                    SetField.Disqualified(rule.action, rule.action_value, product);
                                    break;
                            }
                        }

                        break;
                    
                    case "credit_score":
                        if (EvalField.Credit_Score(rule.comparison, rule.parameter_value, person))
                        {
                            switch (rule.result_field)
                            {
                                case "interest_rate":
                                    SetField.Interest_Rate(rule.action, Convert.ToDecimal(rule.action_value), product);
                                    break;

                            }
                        }
                        break;
                        
                    case "name":
                        if (EvalField.Name(rule.comparison, rule.parameter_value, product))
                        {
                            switch (rule.result_field)
                            {
                                case "interest_rate":
                                    SetField.Interest_Rate(rule.action, Convert.ToDecimal(rule.action_value), product);
                                    break;

                            }
                        }
                        break;
                        
                }

            }


            string output = String.Format("product.name == {0}\n", product.name);
            output += String.Format("product.interest_rate == {0}\n", product.interest_rate);
            output += String.Format("product.disqualified == {0}\n\n", product.disqualified);

            Console.WriteLine(output);
            return output;
        }
        public static class EvalField
        {
            public static bool None (string comparison, string value)
            {
                return comparison == "always";
            }
            public static bool State(string condition, string value, Person person)
            {
                return condition == "eq" && person.state == value;
            }
            public static bool Credit_Score(string condition, string value, Person person)
            {
                return (condition == "ge" && person.credit_score >= Convert.ToInt32(value)) ||
                    (condition == "lt" && person.credit_score < Convert.ToInt32(value));
            }
            public static bool Name(string condition, string value, Product product)
            {
                bool a = condition == "eq";
                bool b = product.name == value;
                return (condition == "eq" && product.name == value) ? true : false;
            }
        }
        public static class SetField
        {
            public static void Interest_Rate(string action, decimal action_value, Product product)
            {
                product.interest_rate = (action == "set" ? action_value :
                    (action == "add" ? product.interest_rate + action_value :
                        (action == "sub" ? product.interest_rate - action_value : 0)));
            }
            public static void Disqualified
                (string action, string action_value, Product product)
            {
                product.disqualified = action == "set" ? Convert.ToBoolean(action_value) : product.disqualified;
            }
        }
    }
}
