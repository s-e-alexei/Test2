using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            public List<string> GetAllFiles(string sDirt);
            {
                List<string> st = new List<string>();

                //  List<Double[]> st = new List<Double[]>();
                try
                {
                    foreach (string file in Directory.GetFiles(sDirt))
                    {
                        st.Add(file);
                    }
                    foreach (string fl in Directory.GetDirectories(sDirt))
                    {
                        st.AddRange(GetAllFiles(fl));
                    }

                    //for (string. i = 0; string. i < 12; string. i++)

                    //foreach (string line in System.IO.File.ReadLines($@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Compartments\\S1.csv"))
                    //     st.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());

                }
                catch (Exception e)
                {
                    Console.WriteLine("NOT READ");
                    Console.WriteLine(e.Message);
                }
                return st;

                List<Cargo> cargo = new List<Cargo>();
                foreach (Double[] item in st)
                {
                    cargo.Add(new Cargo(item));
                    foreach (var subitem in item)
                        Console.Write(subitem + " ");
                    Console.WriteLine();
                }
            }
            List<Double[]> st1 = new List<Double[]>();
            try
            {                
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Trim\\Trim.csv"))
                    st1.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            Dif dif = new Dif(st1[0]);
                foreach (var subitem in dif.T)
                    Console.Write(subitem + " ");
                    
                Console.WriteLine();
            Console.WriteLine("Input SoundingI:");
            
            double DifShip = -0.35;
            int pos1 = 0;
            //double Tt = 0;
            for (int i = 0; i < dif.T.Length; i++)
            {
                if (dif.T[i]< DifShip)
                {
                    pos1 = i - 1; //x1 = xmin
                    Console.WriteLine(pos1 + "   ");
                    
                    break;
                }
            }
            
            // double SoundingI = Convert.ToDouble(Console.ReadLine());
            double SoundingI = 5;
            int pos2 = 0;
            //double Tt = 0;
            for (int i = 0; i < cargo.Count; i++)
            {
                if (cargo[i].V[1] < SoundingI)
                {
                    pos2 = i - 1; //x1 = xmin
                    break;
                }
            }
            Console.WriteLine(pos2 + "   ");
            Console.WriteLine();
            // Тут необходимо произвести интерполяцию и найти все значение V1, V2 ... V9, исходя из значения SoundingI (например  SoundingI = 5)
            // попытался найти Vi для столбца Volume1, массива cargo. Выводит ошибку.

            //double V1i = Math.Abs((((cargo[pos2 + 1].Volume1 - cargo[pos2].Volume1))/ (cargo[pos2 + 1].Sounding- cargo[pos2].Sounding)) * (SoundingI - cargo[pos2].Sounding) + cargo[pos2].Volume1);

            Console.WriteLine(cargo[pos2].V[pos1+2]);

            double v00 = cargo[pos2].V[pos1 + 2];
            double v01 = cargo[pos2].V[pos1 + 2 + 1];
            double v10 = cargo[pos2 + 1].V[pos1 + 2];
            double v11 = cargo[pos2 + 1].V[pos1 + 2 + 1];
            double s0 = cargo[pos2].V[1];
            double s1 = cargo[pos2+1].V[1];
            double d0 = dif.T[pos1];
            double d1 = dif.T[pos1+1];
            double V1i = interpolate(v00,v01,v10,v11, SoundingI, DifShip, s0, s1, d0, d1);            //double yi1 = Math.Abs((((compartment[pos1 + 1].Y - compartment[pos1].Y)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Y);
            //double zi1 = Math.Abs((((compartment[pos1 + 1].Z - compartment[pos1].Z)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Z);

            Console.WriteLine("V1i: " + V1i);
            //Console.WriteLine("yi1: " + yi1);
            //Console.WriteLine("zi1; " + zi1);
            Console.WriteLine();



            /*
            double[] Dif = new double[9];

            for (int i = 0; i < dif.Count; i++)
            {
                Dif[i] = 
            }
            foreach (var item in dif.Count)
            {

            }*/
            Console.Read();




        }

        private static double interpolate(double v00, double v01, double v10, double v11, double s, double d, double s0, double s1, double d0, double d1)
        {
            //double v1 = v00+(s-s0)*(v10-v00) / (s1-s0);
            //double v2 = v01+(s - s0) * (v11 - v01) / (s1 - s0);
            //double v3 = v1+(d-d0)*(v2-v1) / (d1-d0);

            double v1 = v00 + (s - s0) * ((v10 - v00) / (s1 - s0));
            double v2 = v01 + (s - s0) * ((v11 - v01) / (s1 - s0));
            double v3 = v1 + (d - d0) * ((v2 - v1) / (d1 - d0));

            return v3;
        }
    }
}
