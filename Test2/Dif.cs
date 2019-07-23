using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Dif
    {
        private Double T0;
        private Double T1;
        private Double T2;
        private Double T3;
        private Double T4;
        private Double T5;
        private Double T6;
        private Double T7;
        private Double T8;

        public double T01 { get => T0; set => T0 = value; }
        public double T11 { get => T1; set => T1 = value; }
        public double T21 { get => T2; set => T2 = value; }
        public double T31 { get => T3; set => T3 = value; }
        public double T41 { get => T4; set => T4 = value; }
        public double T51 { get => T5; set => T5 = value; }
        public double T61 { get => T6; set => T6 = value; }
        public double T71 { get => T7; set => T7 = value; }
        public double T81 { get => T8; set => T8 = value; }

        public Dif(Double T0, Double T1, Double T2, Double T3, Double T4, Double T5, Double T6, Double T7, Double T8)
        {
            this.T0 = T0;
            this.T1 = T1;
            this.T2 = T2;
            this.T3 = T3;
            this.T4 = T4;
            this.T5 = T5;
            this.T6 = T6;
            this.T7 = T7;
            this.T8 = T8;

        }

        public override string ToString()
        {
            return $"{T01}, {T11}, {T21}, {T31}, {T41}, {T51}, {T61}, {T71}, {T81},\n";
        }
    }
}
