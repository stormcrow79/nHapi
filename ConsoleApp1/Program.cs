using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHapi.Base.Model;
using NHapi.Base.Parser;
using NHapi.Base.Validation;
using NHapi.Base.Validation.Implementation;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parser = new PipeParser() { ValidationContext = new CustomValidation() };
            parser.Parse(File.ReadAllText(@"C:\HLINK\HL7_in\RSDAU\0081768592_20231009140418-1.hl7"));
        }
    }

    public class CustomValidation : ValidationContextImpl
    {
        public CustomValidation()
        {
            IRule trim = new TrimLeadingWhitespace();
            PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", trim));
            PrimitiveRuleBindings.Add(new RuleBinding("*", "ST", trim));
            PrimitiveRuleBindings.Add(new RuleBinding("*", "TX", trim));

            IRule size200 = new SizeRule(200);
            //IRule size65536 = new SizeRule(65536);
            //PrimitiveRuleBindings.Add(new RuleBinding("*", "FT", size65536));
            PrimitiveRuleBindings.Add(new RuleBinding("*", "ID", size200));
            PrimitiveRuleBindings.Add(new RuleBinding("*", "IS", size200));
        }
    }
}
