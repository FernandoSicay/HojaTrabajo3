using System;
using control;

namespace primerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatShow formatocvs = new FormatCSV();
            formatocvs.showData(args);
        }
    }
}
