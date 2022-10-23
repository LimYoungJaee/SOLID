using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_02
{
    public class ExcelReportGenerationHelper : ReportGenerationHelper
    {
        public override void GenerateReport()
        {
            Console.WriteLine("ExcelReport()");
        }
    }
}
