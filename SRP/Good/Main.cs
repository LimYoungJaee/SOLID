using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GoodOrderService goodOrderService = new GoodOrderService();
            goodOrderService.CreateOrder();
            GoodPaymentService goodPaymentService = new GoodPaymentService();
            goodPaymentService.MakePayment();
            GoodGenerateInvoice goodGenerateInvoice = new GoodGenerateInvoice();
            goodGenerateInvoice.GenerateInvoice();
            GoodEmailInvoice goodEmailInvoice = new GoodEmailInvoice();
            goodEmailInvoice.EmailInvoice();
        }
    }
}
