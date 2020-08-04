using System;
using System.Collections.Generic;
using System.Text;

namespace LUMO.Core
{
    public class Generate
    {
        public static int RandomInt()
        {
            Random random = new Random();
            return random.Next();
        }

        public static int RandomInt(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }

        public static int RandomInt(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
