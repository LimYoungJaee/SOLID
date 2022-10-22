using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC01
{
    internal class GenerateJSONReport : IGernerateReport
    {
        public bool GenerateReport()
        {
            Console.WriteLine("GenerateJSONReport");
            return true;
        }
    }
}
