
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_02
{
    public abstract class ReportGenerationHelper
    {
        public Client client;

        public ReportGenerationHelper()
        {
            this.client = new Client();
        }
        public abstract void GenerateReport();
    }
}
