using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hum.ArchitecturePractice.Editor
{
    public class Math
    {
        public int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
