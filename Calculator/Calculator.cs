using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class Calculator
    {
        private List<Operation> operations;

        public Calculator()
        {
            this.operations = new List<Operation>();
            this.operations.Add(new Add("Add", " + "));
            this.operations.Add(new Subtract("Substract", " - "));
            this.operations.Add(new Multiply("Multiply", " * "));
            this.operations.Add(new Divide("Divide", " / "));
            this.operations.Add(new Pow("Pow", " ^ ")); 
            this.operations.Add(new Modulus("Modulus", " mod "));
            
        }

        public int Exit()
        {
            return this.operations.Count + 1;
        }


        public string PerformOperation(int op, string op1, string op2)
        {
            try
            {
                bool isDecimal = IsDecimalOperation(op1, op2);
                Result result = null;
                if (isDecimal == true)
                {
                    result = this.operations[op - 1].Operate(Double.Parse(op1), Double.Parse(op2));
                }
                else
                {
                    result = this.operations[op - 1].Operate(Int32.Parse(op1), Int32.Parse(op2));
                }

                if (result != null)
                {
                    return this.operations[op - 1].Print(op1, op2, result);
                }
                else
                {
                    return "This operation cannot be performed.";
                }
            }
            catch (FormatException)
            {
                return "This operation cannnot be performed.";
            }
           
        }

        public Boolean IsDecimalOperation(string op1, string op2)
        {
            bool DecimalOp = false;

            if( op1.Contains(".") || op2.Contains(".") ) DecimalOp = true;
            if (op1.Contains(",") || op2.Contains(",") ) DecimalOp = true;

            return DecimalOp;
        }

        private int GetOperationBySign(string sign)
        {
            for(int i = 0; i<this.operations.Count; i++) { 
            
                if(sign == this.operations[i].GetSymbol()) return i+1;

            }
            return 0;
        }
        
        public string PerformOperation(string operation)
        {
            string result = "";

            try
            {
                string[] components = operation.Split(" ");
               
                int op = this.GetOperationBySign(components[1]);

                if (op != 0)
                {
                    result = this.PerformOperation(op, components[0], components[2]);
                }
            }
            catch(Exception) {
                return "Operation could not be performed";
            }
            
            

            return result;
        }
    }
}
