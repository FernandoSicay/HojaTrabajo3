using System;
using control;

namespace primerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatShow format = new DataFormatDecoratorControl(new FormatShowControl());
            format.showData(args);
            //System.Console.Write(args.Length);
        }
    }
}
