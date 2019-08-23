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

        public static Dif Load(ref int pos1, double DifShip)
        {

            List<Double[]> st1 = new List<Double[]>();
            try
            {
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Trim\\Trim.csv"))
                {
                    st1.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            Dif dif = new Dif(st1[0]);
            foreach (var subitem in dif.T)
            {
                Console.Write(subitem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Input SoundingI:");

    
            pos1 = 0;
            //double Tt = 0;
            for (int i = 0; i < dif.T.Length; i++)
            {
                if (dif.T[i] < DifShip)
                {
                    pos1 = i - 1; //x1 = xmin
                    Console.WriteLine(pos1 + "   ");

                    break;
                }
            }
            return dif;
        }

    }
}
