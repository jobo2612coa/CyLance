using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TestRules
{
    public class RulesEngine
    {
        public string runRules(Person person, Product product, IList<Rule> rules)
        {
            foreach (Rule rule in rules)
            {
                RateField.Rate(person, product, rule);
            }

            string output = String.Format("product.name == {0}\n", product.name);
            output += String.Format("product.interest_rate == {0}\n", product.interest_rate);
            output += String.Format("product.disqualified == {0}\n\n", product.disqualified);

            
            return output;
        }
    }
    public static class RateField
    {
        /* Notes: Structure of Rules
         * general structure:  condition field, comparison (always, eq, ge, lt), value, result field, action (set, add, sub), value
         * initial rules:
         * 1 - (empty), interest_rate, set, value
         * 2 - state = "Florida", disqualified, set, true 
         * 3 - credit_score >= 720, interest_rate, sub, .3
         * 4 - credit_score < 720, interest_rate, add, .5
         * 5 - name = "7-1 ARM", interest_rate, add, .5
         * 
         * 1 - select *                                   set interest_rate = value
         * 2 - select state        = 'Florida'            set disqualified  = true
         * 3 - select credit_score >= 720                 set interest_rate = interest_rate - 0.3
         * 4 - select credit_score <  720                 set interest_rate = interest_rate + 0.5
         * 5 - select name         =  '7 - 1 ARM'         set interest_rate = interest_rate + 0.5
         */

        public static string Rate(Person person, Product product, Rule rule)
        {
            DataRow[] foundRows;
            using (DataTable dataTable = new DataTable())
            {
                dataTable.Columns.Add(new DataColumn("Query"));
                dataTable.Columns.Add(new DataColumn("Action_Function"));
                dataTable.Columns.Add(new DataColumn("Action_Field"));
                dataTable.Columns.Add(new DataColumn("Action_Value"));
                dataTable.Columns.Add(new DataColumn("Credit_Score"));
                dataTable.Columns.Add(new DataColumn("State"));
                dataTable.Columns.Add(new DataColumn("Disqualified"));
                dataTable.Columns.Add(new DataColumn("Interest_Rate"));
                dataTable.Columns.Add(new DataColumn("Name"));

                dataTable.Rows.Add(
                    rule.query,
                    rule.action_function,
                    rule.action_field,
                    rule.action_value,
                    person.credit_score,
                    person.state,
                    product.disqualified,
                    product.interest_rate,
                    product.name
                    );

                foundRows = dataTable.Select(rule.query);

                if (foundRows.Length == 1)
                {
                    switch (foundRows[0]["Action_Function"].ToString())
                    {
                        case "set":
                            switch (foundRows[0]["Action_Field"].ToString())
                            {
                                case "interest_rate":
                                    product.interest_rate = Convert.ToDecimal(foundRows[0]["Action_Value"]);
                                    break;
                                case "disqualified":
                                    product.disqualified = Convert.ToBoolean(foundRows[0]["Action_Value"]);
                                    break;
                            }
                            break;
                        case "add":
                            switch (foundRows[0]["Action_Field"].ToString())
                            {
                                case "interest_rate":
                                    product.interest_rate += Convert.ToDecimal(foundRows[0]["Action_Value"]);
                                    break;
                            }
                            break;
                        case "sub":
                            switch (foundRows[0]["Action_Field"].ToString())
                            {
                                case "interest_rate":
                                    product.interest_rate -= Convert.ToDecimal(foundRows[0]["Action_Value"]);
                                    break;
                            }
                            break;

                    }
                }
                string output = String.Format("product.name == {0}\n", product.name);
                output += String.Format("product.interest_rate == {0}\n", product.interest_rate);
                output += String.Format("product.disqualified == {0}\n\n", product.disqualified);

                return output;
            }
        }

    }
}

