﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class Divide : Operation
    {
        public Divide(string name, string symbol) : base(name, symbol) 
        { 
        
        }
        public override Result Operate(int op1, int op2)
        {
            try
            {
                IntegerResult result = new IntegerResult(op1 / op2);
                return result;
            }
            catch (DivideByZeroException)
            {
                return new IntegerResult(Int32.MaxValue);
            }
            
        }
        public override Result Operate(double op1, double op2)
        {
            if (op2 == 0)
            {
                return new DoubleResult(Double.MaxValue);
            }
            else
            {
                DoubleResult result = new DoubleResult(op1 / op2);
                return result;
            }
           
        }
    }
}
