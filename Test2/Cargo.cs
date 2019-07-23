using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Cargo
    {
        private Double level;
        private Double sounding;
        private Double volume1;
        private Double volume2;
        private Double volume3;
        private Double volume4;
        private Double volume5;
        private Double volume6;
        private Double volume7;
        private Double volume8;
        private Double volume9;

        public double Level { get => level; set => level = value; }
        public double Sounding { get => sounding; set => sounding = value; }
        public double Volume1 { get => volume1; set => volume1 = value; }
        public double Volume2 { get => volume2; set => volume2 = value; }
        public double Volume3 { get => volume3; set => volume3 = value; }
        public double Volume4 { get => volume4; set => volume4 = value; }
        public double Volume5 { get => volume5; set => volume5 = value; }
        public double Volume6 { get => volume6; set => volume6 = value; }
        public double Volume7 { get => volume7; set => volume7 = value; }
        public double Volume8 { get => volume8; set => volume8 = value; }
        public double Volume9 { get => volume9; set => volume9 = value; }

        public Cargo(Double level, Double sounding, Double volume1, Double volume2, Double volume3, Double volume4, Double volume5, Double volume6, Double volume7, Double volume8, Double volume9)
        {
            this.level = level;
            this.sounding = sounding;
            this.volume1 = volume1;
            this.volume2 = volume2;
            this.volume3 = volume3;
            this.volume4 = volume4;
            this.volume5 = volume5;
            this.volume6 = volume6;
            this.volume7 = volume7;
            this.volume8 = volume8;
            this.volume9 = volume9;
        }

        public override string ToString()
        {
            return $"{Level}, {Sounding}, { Volume1}, { Volume2}, { Volume3}, { Volume4}, { Volume5}, { Volume6}, { Volume7}, { Volume8}, {Volume9},\n";
        }
    }
}
