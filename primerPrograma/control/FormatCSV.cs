
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace control{
    public class FormatCSV : IFormatShow {

        public FormatCSV() {

        }

        public  void showData(String[] args)
        {
            float longitud = args.Length;
            for (int i = 0; i < longitud; i++)
            {
                string text = System.IO.File.ReadAllText(@args[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("[ ArchivoTXT ] [ " +(i+1)+" ]");
                System.Console.WriteLine(text+"\n");
                
            }
        }

    }
}