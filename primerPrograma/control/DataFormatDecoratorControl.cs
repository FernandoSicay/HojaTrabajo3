
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace control{
    public class DataFormatDecoratorControl : FormatDecoratorControl {

        public DataFormatDecoratorControl(IFormatShow decoratedFormat):base(decoratedFormat) {
        }
        public override void showData(String[] args){
            int aux = args.Length;
            System.Console.WriteLine(aux);
            if(args.Length ==1 ){
                    decoratedFormat.showData(args);
            }
            if(args[aux] == "CSV"){
                decoratedFormat.showData(args);
                setCSVFormate(args);
            }
            else if(args[aux + 1] == "HTML"){
                    decoratedFormat.showData(args);
                    setHTMLFormat(args);
            }
            else if(args[aux + 1] == "JSON"){
                    decoratedFormat.showData(args);
                    setJSONFormat(args);
            }
            else if(args[aux + 1] == "XML"){
                    decoratedFormat.showData(args);
                    setXMLFormat(args);
            }

        }

        /// <summary>
        /// @param args
        /// </summary>
        private void setHTMLFormat(String[] args) {
            float longitud = args.Length;
            for (int i = 0; i < longitud; i++)
            {
                string text = System.IO.File.ReadAllText(@args[i]);
                System.Console.WriteLine("<!DOCTYPE html>");
                System.Console.WriteLine("<html lang = es-ES>");
                System.Console.WriteLine("<head><title>programa 2 </title><head>");
                System.Console.WriteLine("<body>");
                System.Console.WriteLine(text+"\n");
                System.Console.WriteLine("</body>");
                System.Console.WriteLine("</html>");
                
            }
        }

        /// <summary>
        /// @param args
        /// </summary>
        private void setCSVFormate(String[] args) {
             float longitud = args.Length;
            for (int i = 0; i < longitud; i++)
            {
                string text = System.IO.File.ReadAllText(@args[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("[ ArchivoTXT ] [ " +(i+1)+" ]");
                System.Console.WriteLine(text+"\n");
                
            }

        }

        /// <summary>
        /// @param args
        /// </summary>
        private void setXMLFormat(String[] args) {
            float longitud = args.Length;
            for (int i = 0; i < longitud; i++)
            {
                string text = System.IO.File.ReadAllText(@args[i]);
            
                System.Console.WriteLine("<tokens>" +text +"\n"+" </tokens>");
                
            }
        }

        /// <summary>
        /// @param args
        /// </summary>
        private void setJSONFormat(String[] args) {
            // TODO implement here
        }

    }
}