using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Linq;

namespace Structure_Classes_Properties
{

    struct Request
    {
        private int codeOrder;
        private Client client;
        private DateTime dateOrder;
        private List<RequestItem> requestItemList;
        private PayType pay;
        public enum PayType
        {
            Cash, Check, Credit
        }
        public Request(int codeOrder, Client client, Request.PayType pay, List<RequestItem> requestItemList)
        {
            this.codeOrder = codeOrder;
            this.client = client;
            this.pay = pay;
            this.dateOrder = DateTime.Now;
            this.requestItemList = requestItemList;
        }
        public double Sum
        {
            get
            {
                double Sum = 0;
                foreach (RequestItem item in requestItemList)
                {

                    Sum += item.count * item.ar.priceProduct;
                }
                return Sum;
            }
        }
        public void Print()
        {
            WriteLine($"код заказа:{codeOrder} \nклиент: {client.Get()} \nдата заказа: {dateOrder.ToString("yyyy /MM/dd")} \nформa оплаты: { pay}");

            foreach (RequestItem requestItem in requestItemList)
            {

                Console.WriteLine("{0}", requestItem);
            }

            WriteLine($"сумма заказа : {Sum}");
        }
    }
}
