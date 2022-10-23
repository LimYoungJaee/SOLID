using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC01
{
    internal class GenerateHTMLReport : IGernerateReport
    {
        public bool GenerateReport()
        {
            Console.WriteLine("GenerateHTMLReport");
            return true;
        }
    }
}
