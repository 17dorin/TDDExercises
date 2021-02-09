using System;
using System.Collections.Generic;
using System.Text;

namespace MathStuff
{
    public enum Number
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine
    }
    public class Kata
    {
        public string Convert(int num)
        {
            Number n = (Number)num;
            return n.ToString();
        }
    }
}
