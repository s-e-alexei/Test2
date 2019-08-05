using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Dif
    {
        Double[] t;

        public double[] T { get => t; set => t = value; }

        
        public Dif(Double[] st1)
        {
            this.T = st1;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
