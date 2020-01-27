using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsStrutturaDati1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numeri = new List<double>();
            using (StreamReader sr = new StreamReader("file.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double d = double.Parse(line);
                    numeri.Add(d);
                }

            }
            using (StreamWriter sw = new StreamWriter("filecontrario.txt", false, Encoding.UTF8))
            {
                for (int i = numeri.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(numeri[i]);
                }
            }
        }
    }
}
