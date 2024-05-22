using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWorkII.Calculator
{
    public class DoubleResult : Result
    {
        private double value;
        public override object GetValue()
        {
            return value;
        }
        public DoubleResult(double value)
        {
            this.value = value;
        }
    }
}
