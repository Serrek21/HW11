using System;

namespace HW11
{
    internal class Task2
    {
        public class DecimalNumber
        {
            public int Number { get; set; }

            public DecimalNumber(int number)
            {
                Number = number;
            }

            public string ToBinary()
            {
                return Convert.ToString(Number, 2);
            }

            public string ToOctal()
            {
                return Convert.ToString(Number, 8);
            }

            public string ToHexadecimal()
            {
                return Convert.ToString(Number, 16);
            }
        }
    }
}
