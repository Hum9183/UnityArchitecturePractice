using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hum.FizzBuzz.Editor
{
    public class PassThroughRule : IReplaceRule
    {
        public string Apply(string carry, int number)
        {
            return number.ToString();
        }

        public bool Match(string carry, int number)
        {
            return carry.Equals(string.Empty);
        }
    }
}
