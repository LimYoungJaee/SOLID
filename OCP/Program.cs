using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateHTMLReport generateHTMLReport = new GenerateHTMLReport();
            generateHTMLReport.GenerateReport();
            GenerateJSONReport generateJSONReport = new GenerateJSONReport();
            generateJSONReport.GenerateReport();

            generateJSONReport = new GenerateJSONReport();
        }
    }
}