using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appName = "Mencari lokasi loker";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(appName);
            Console.ResetColor();   
            here:
            Console.WriteLine("____________________________");
            Console.WriteLine("Masukan nomer loker: ");

 
            //Input user
            string input = Console.ReadLine();
            int loker = 0;
            loker = Int32.Parse(input);

            //proses

            //menyiapkan variabel
            int x = loker;
            int lantai = 1;
            //menentukan jumlah loker
            bool loker_5 = true;
            bool loker_6 = false;
            bool loker_7 = false;
            List<int> temp = new List<int>();

            if (input != null)
            {
                foreach (int i in Enumerable.Range(1, x + 1))
                {
                    temp.Add(i);
                    if (x == i)
                    {
                        //output
                        Console.WriteLine("loker nomor: " + input + " Berada pada lantai: " + lantai);
                        goto here;
                    }
                    else if (loker_5 && temp.Count() == 5)
                    {
                        lantai++;
                        loker_5 = false;
                        loker_6 = true;
                        temp = new List<int>();
                    }
                    else if (loker_6 && temp.Count() == 6)
                    {
                        lantai++;
                        loker_6 = false;
                        loker_7 = true;
                        temp = new List<int>();
                    }
                    else if (loker_7 && temp.Count() == 7)
                    {
                        lantai++;
                        loker_7 = false;
                        loker_5=true;
                        temp = new List<int>();
                    }

                }
            }
            
        }
    }
}
