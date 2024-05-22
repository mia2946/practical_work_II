using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public abstract class Operation
    {
        private string symbol;
        private string name;

        public Operation(string name, string symbol) { 
            this.name = name;
            this.symbol = symbol;
        }

        public abstract Result Operate(int op1, int op2);
        public abstract Result Operate(double op1, double op2);

        public string Print(string op1, string op2, Result result)
        {
            return $"{result.GetValue()}";
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetSymbol()
        {
            return this.symbol.Trim();
        }
    }
}