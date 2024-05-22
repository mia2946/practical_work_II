﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class Modulus : Operation
    {
        public Modulus(string name, string symbol) : base(name, symbol)
        { 

        }

        public override Result Operate(int op1, int op2)
        {
            if (op2 == 0 || op2 == 1) return new IntegerResult(0);

            int dividend = Math.Abs(op1);
            int divisor = Math.Abs(op2);
            while (dividend > divisor)
            {
                dividend -= divisor;
            }
            Result result = new IntegerResult(dividend);
            return result;
        }
        public override Result Operate(double op1, double op2)
        {
            return null;
        }

    }
}
