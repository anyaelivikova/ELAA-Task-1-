using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace задача_1_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("INPUT.TXT");
            string[] arr = sr.ReadLine().Split();

            int n = int.Parse(arr[0]);
            double q = double.Parse(arr[1].Replace('.', ','));

            bool result = true;

            for (int i = 0; i < n; i++)
            {
                string[] line = sr.ReadLine().Split();

                int x1, y1, x2, y2 = 0;
                double eps = 0.000000000001;

                x1 = int.Parse(line[0]);
                y1 = int.Parse(line[1]);
                x2 = int.Parse(line[2]);
                y2 = int.Parse(line[3]);

                if (Math.Sqrt(x2 * x2 + y2 * y2) > q * Math.Sqrt((x1 * x1 + y1 * y1) * (1 + eps)))
                    result = false;
            }

            sr.Close();

            string res = result == true ? "Yes" : "No";
            File.WriteAllText("OUTPUT.TXT", res);
        }
    }
}

