using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class IntegerResult : Result
    {
        private int value;
        public override object GetValue()
        {
            return value;
        }
        public IntegerResult(int value)
        {
            this.value = value;
        }
    }
}
