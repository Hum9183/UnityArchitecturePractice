using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hum.FizzBuzz.Editor
{
    public class NumberConverter
    {
        private readonly List<IReplaceRule> _replaceRules;

        public NumberConverter(List<IReplaceRule> replaceRules)
        {
            _replaceRules = replaceRules;
        }

        public string Convert(int number)
        {
            var carry = string.Empty;
            foreach (var replaceRule in _replaceRules)
            {
                if (replaceRule.Match(carry, number))
                    carry = replaceRule.Apply(carry, number);
            }

            return carry;
        }
    }
}
