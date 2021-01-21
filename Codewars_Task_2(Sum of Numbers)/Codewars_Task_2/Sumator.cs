using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars_Task_2
{
    class Sumator
    {
        public int GetSum(int a, int b)
        {
            int sum = 0;
            int firstNumber;
            int lastNumber;
            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                firstNumber = a;
                lastNumber = b;
            }
            else
            {
                firstNumber = b;
                lastNumber = a;
            }
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
