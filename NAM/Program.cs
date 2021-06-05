using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace NAM
{
    class Program
    {
        struct Rule
        {
            public String from { get; private set; }
            public String to { get; private set; }
            public bool last { get; private set; }
            public Rule(String from, String to, bool last)
            {
                this.from = from;
                this.to = to;
                this.last = last;
            }
        }

        static public String ReplaceFirst(String input, String from, String to)
        {
            int index = input.IndexOf(from);
            String result = input.Remove(index, from.Length).Insert(index, to);
            return result;
        }

        static void Main(string[] args)
        {
            List<Rule> Rules = new List<Rule>();
            Rules.Add(new Rule("*a", "aA*", false));
            Rules.Add(new Rule("*b", "bB*", false));
            Rules.Add(new Rule("*", "#", false));
            Rules.Add(new Rule("Aa", "aA", false));
            Rules.Add(new Rule("Ab", "bA", false));
            Rules.Add(new Rule("Ba", "aB", false));
            Rules.Add(new Rule("Bb", "bB", false));
            Rules.Add(new Rule("A#", "#a", false));
            Rules.Add(new Rule("B#", "#b", false));
            Rules.Add(new Rule("#", "", true));
            Rules.Add(new Rule("", "*", false));

            Console.WriteLine("Правила:");
            foreach (Rule rule in Rules)
            {
            Console.WriteLine("{0} -> {1}", rule.from, rule.to);
            }

            Console.WriteLine("");

            String input = args[1];
            Console.WriteLine(input);
            int flag = 1;
            while (flag != 0)
            {
                flag = 0;
                foreach (Rule rule in Rules)
                {
                    if (rule.from == "")
                    {
                        flag++;
                        input = rule.to + input;
                        Console.WriteLine(input);
                        if (rule.last == true && flag == 1)
                            flag = 0;
                        break;
                    }
                    else if (input.Contains(rule.from))
                    {
                        flag++;
                        input = ReplaceFirst(input, rule.from, rule.to);
                        Console.WriteLine(input);
                        if (rule.last == true && flag == 1)
                            flag = 0;
                        break;
                    }

                }
            }
        }
    }
}
