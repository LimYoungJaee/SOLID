using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//main
namespace SRP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BadOrderService badOrderService = new BadOrderService();
            badOrderService.CreateOrder();
            badOrderService.MakePayment();
            badOrderService.GenerateInvoice();
            badOrderService.EmailInvoice();
        }
    }
}
