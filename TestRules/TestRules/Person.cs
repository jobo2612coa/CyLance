using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{
    public class Person
    {

        public int credit_score { get; set; }
        public string state { get; set; }
        public Person (int _credit_score, string _state)
        {
            credit_score = _credit_score;
            state = _state;

        }
    }
}
