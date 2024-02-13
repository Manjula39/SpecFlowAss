using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAss
{
    public class Calculator
    {
        public int Num1;
        public int Num2;
        public int result;
        public void EnterNumber(int number)
        {
            if (Num1 == 0)
                Num1 = number;
            else
                Num2 = number;
        }
        public int Subtract()
        {
            result = Num1 - Num2;
            return result;
        }
        public int Multiply()
        {
            result = Num1 * Num2;
            return result;
        }
        public int Divide()
        {
            result = Num1 / Num2;
            return result;
        }
    }
    }
