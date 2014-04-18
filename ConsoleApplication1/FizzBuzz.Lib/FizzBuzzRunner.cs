namespace FizzBuzz.Lib
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class FizzBuzzRunner
    {
        private readonly ICollection<FizzBuzzRule> _rules;

        public FizzBuzzRunner(IEnumerable<FizzBuzzRule> rules = null)
        {
            _rules = (rules != null)
                ? rules.OrderByDescending(r => r.Weight).ToList()
                : new List<FizzBuzzRule>();
        }

        public void AddRule(int weight, int divider, string replacement)
        {
            _rules.Add(new FizzBuzzRule {Weight = weight, Divider = divider, ReplacementString = replacement});
        }

        public string RunSingleUsingRules(int number)
        {
            foreach (var rule in _rules)
            {
                if ((number % rule.Divider) == 0)
                {
                    return rule.ReplacementString;
                }
            }

            return number.ToString();
        }

        public IEnumerable<string> RunUsingRules(int first, int last)
        {
            var results = new List<string>();

            for (var i = first; i <= last; i++)
            {
                var result = i.ToString();

                foreach (var rule in _rules)
                {
                    if ((i % rule.Divider) == 0)
                    {
                        result = rule.ReplacementString;
                        break;
                    }
                }

                results.Add(result);
            }

            return results;
        }

        public IEnumerable<string> RunEx(int first, int last)
        {
            var results = new Collection<string>();

            for (var i = first; i <= last; i++)
            {
                if ((i%15) == 0)
                {
                    results.Add("FizzBuzz");
                }
                else if ((i%3) == 0)
                {
                    results.Add("Fizz");
                }
                else if ((i%5) == 0)
                {
                    results.Add("Buzz");
                }
                else
                {
                    results.Add(i.ToString());
                }
            }

            return results;
        }

        public string[] Run(int first, int last)
        {
            var size = last - first + 1;
            var results = new string[size];

            int index = 0;
            for (var i = first; i <= last; i++)
            {
                if ((i % 15) == 0)
                {
                    results[index++] = "FizzBuzz";
                }
                else if ((i % 3) == 0)
                {
                    results[index++] = "Fizz";
                }
                else if ((i % 5) == 0)
                {
                    results[index++] = "Buzz";
                }
                else
                {
                    results[index++] = i.ToString();
                }
            }

            return results;
        }
    }
}
