using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hum.FizzBuzz.Editor
{
    public class CyclicNumberRule : IReplaceRule
    {
        private readonly int _baseNumber;
        private readonly string _replacement;

        public CyclicNumberRule(int baseNumber, string replacement)
        {
            _baseNumber = baseNumber;
            _replacement = replacement;
        }

        public string Apply(string carry, int number)
        {
            return $"{carry}{_replacement}";
        }

        public bool Match(string carry, int number)
        {
            return number % _baseNumber is 0;
        }
    }
}
