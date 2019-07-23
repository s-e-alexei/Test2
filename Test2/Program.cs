using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double[]> st = new List<Double[]>();
            try
            {             
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Compartments\\S1.csv"))
                    st.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }
            List<Cargo> cargo = new List<Cargo>();
            foreach (Double[] item in st)
            {
                cargo.Add(new Cargo(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10]));
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();
            }
            
            List<Double[]> st1 = new List<Double[]>();
            try
            {                
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Test2\\Test2\\Data\\Trim\\Trim.csv"))
                    st.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }
            List<Dif> dif = new List<Dif>();
            foreach (Double[] item in st)
            {
                dif.Add(new Dif(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]));
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Input SoundingI:");

           // double SoundingI = Convert.ToDouble(Console.ReadLine());
           double SoundingI = 5;
            int pos1 = 0;
            //double Tt = 0;
            for (int i = 0; i < cargo.Count; i++)
            {
                if (cargo[i].Sounding < SoundingI)
                {
                    pos1 = i - 1; //x1 = xmin
                    break;
                }
            }
            Console.WriteLine(pos1 + "   ");
            Console.WriteLine();
            // Тут необходимо произвести интерполяцию и найти все значение V1, V2 ... V9, исходя из значения SoundingI (например  SoundingI = 5)
            // попытался найти Vi для столбца Volume1, массива cargo. Выводит ошибку.

            double V1i = Math.Abs((((cargo[pos1 + 1].Volume1 - cargo[pos1].Volume1))/ (cargo[pos1 + 1].Sounding- cargo[pos1].Sounding)) * (SoundingI - cargo[pos1].Sounding) + cargo[pos1].Volume1);
            //double yi1 = Math.Abs((((compartment[pos1 + 1].Y - compartment[pos1].Y)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Y);
            //double zi1 = Math.Abs((((compartment[pos1 + 1].Z - compartment[pos1].Z)) / (compartment[pos1 + 1].Volume - compartment[pos1].Volume)) * (vi1 - compartment[pos1].Volume) + compartment[pos1].Z);

            Console.WriteLine("xi1: " + V1i);
            //Console.WriteLine("yi1: " + yi1);
            //Console.WriteLine("zi1; " + zi1);
            Console.WriteLine();

            
            Console.Read();




        }
    }
}
