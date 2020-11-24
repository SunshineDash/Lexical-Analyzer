using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lexical_Analyzer
{
    class Syntax
    {
        public string If { get; set; }
        public string Then { get; set; }
        public string Else { get; set; }
        public string Or { get; set; }
        public string Xor { get; set; }
        public string And { get; set; }
        public string Comment { get; set; }
        public string Initialize { get; set; }

        static private Regex regexIf = new Regex(@".*[\s]?if.*[\s]?");
        static private Regex regexThen = new Regex(@".*[\s]?then.*[\s]?");
        static private Regex regexElse = new Regex(@".*[\s]?else.*[\s]?");
        static private Regex regexInitilization = new Regex(@".*[\S].*[\s]?=.*[\s]?[0-9].*[\s]?;.*[\s]?");
        static private Regex regexOr = new Regex(@"[(].*[\s]?.*[\S].*[\s]?or.*[\s]?.*[\S].*[\s]?[)].*[\s]?;.*[\s]?");
        static private Regex regexXor = new Regex(@"[(].*[\s]?.*[\S].*[\s]?->.*[\s]?.*[\S].*[\s]?[)].*[\s]?;.*[\s]?");
        static private Regex regexAnd = new Regex(@"[(].*[\s]?.*[\S].*[\s]?&&.*[\s]?.*[\S].*[\s]?[)].*[\s]?;.*[\s]?"); 
        static private Regex regexComment = new Regex(@"{.*?}");

        static public bool CheckSyntax(string text)
        {
            Regex regexT = new Regex(@"" + regexIf + @"(" + regexAnd + @"|" + regexXor + "|" + regexOr + @")" + regexThen + regexInitilization);
            Regex regexE = new Regex(@"" + regexIf + @"(" + regexAnd + @"|" + regexXor + "|" + regexOr + @")" + regexThen + regexInitilization + regexElse + regexInitilization);
            while (text != string.Empty)
            {
                if (regexT.IsMatch(text) || regexE.IsMatch(text))
                {
                    text = regexE.Replace(text, string.Empty);
                    text = regexT.Replace(text, string.Empty);
                }
                else
                {
                    if (regexComment.IsMatch(text))
                    {
                        text = regexComment.Replace(text, " ");
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static public Syntax TextAnalyzer(string text)
        {
            Syntax syntax = new Syntax();
            syntax.Comment = regexComment.Match(text).ToString();
            text = regexComment.Replace(text, "\n\n");

            syntax.If = regexIf.Match(text).ToString();

            syntax.And = regexAnd.Match(text).ToString();
            text = regexAnd.Replace(text, "\n\n");

            syntax.Xor = regexXor.Match(text).ToString();
            text = regexXor.Replace(text, "\n\n");

            syntax.Or = regexOr.Match(text).ToString();
            text = regexOr.Replace(text, "\n\n");

            text = regexIf.Replace(text, "\n\n");

            //syntax.Initialize = regexInitilization.Match(text).ToString();
            syntax.Then = regexThen.Match(text).ToString();
            text = regexThen.Replace(text, "\n\n");

            //syntax.Initialize += regexInitilization.Match(text).ToString();
            syntax.Else = regexElse.Match(text).ToString();
            //text = regexElse.Replace(text, "\n\n");
            return syntax;
        }
    }
}
