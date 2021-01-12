using System;
using System.Collections.Generic;
using System.Text;

namespace TestRules
{

    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string parameter_field { get; set; }
        public string comparison { get; set; }
        public string parameter_value { get; set; }
        public string result_field { get; set; }
        public string action { get; set; }
        public string action_value { get; set; }
    }

}
