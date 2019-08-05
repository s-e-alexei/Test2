using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Cargo
    {
        Double[] v;

        public double[] V { get => v; set => v = value; }

        public Cargo(Double[] vv)
        {

            this.v = vv;
        }

    }
}
