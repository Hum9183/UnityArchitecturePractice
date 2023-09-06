using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hum.Sample.Editor
{
    public class MathUtil
    {
        public int Saturate(int value, int minValue, int maxValue)
        {
            var math = new Math();
            return math.Min(math.Max(value, minValue), maxValue);
        }
    }
}
