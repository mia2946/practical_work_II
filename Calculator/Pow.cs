using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class Pow : Operation
    {
        public Pow(string name, string symbol) : base(name, symbol)
        {
        }
        public override Result Operate(int op1, int op2)
        {
            int power = op1;
            if (op2 == 0) return new IntegerResult(1);

            
            for (int i = 1; i < op2; i++)
            {
                power = power * op1;
            }
            Result result = new IntegerResult(power);
            return result;
        }
        public override Result Operate(double op1, double op2)
        {
            return null;
        }

    }
}
