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

        public Cargo(Double[] st)
        {

            this.V = st;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public static Cargo Load(ref int pos2, double SoundingI)
        {
            List<Double[]> st = new List<Double[]>();
            try
            {
                foreach (string line in System.IO.File.ReadLines($@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Compartments\\S1.csv"))
                    st.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());

            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            //return st;

            List<Cargo> cargo = new List<Cargo>();
            foreach (Double[] item in st)
            {
                cargo.Add(new Cargo(item));
                foreach (var subitem in item)
                    Console.Write(subitem + " ");
                Console.WriteLine();
            }

            // double SoundingI = Convert.ToDouble(Console.ReadLine());
                        
             pos2 = 0;
            for (int i = 0; i < cargo.Count; i++)
            {
                if (cargo[i].V[1] < SoundingI)
                {
                    pos2 = i - 1; //x1 = xmin
                    Console.WriteLine(pos2 + "   ");
                    Console.WriteLine();
                    break;
                    
                }
                
            return cargo[i];
            }
            // return cargo[i];   //return cargo[i].V[1];           

        }
        
    }
}
