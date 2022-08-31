using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Structure_Classes_Properties
{

    struct Client
    {
        private int codeClient;
        private string name;
        private string adress;
        private string phone;
        private int countOrder;
        private int sumOrder;
        private ClientType clientType;
        public enum ClientType
        {
            Bronze, Silver, Gold, StarPlatinum
        }
        public string Get()
        {
            return this.name;
        }

        public Client(int codeClient, string name, string adress, string phone, int countOrder, int sumOrder)
        {
            this.codeClient = codeClient;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.countOrder = countOrder;
            this.sumOrder = sumOrder;

            if (this.sumOrder < 1000)
            {
                this.clientType = ClientType.Bronze;
            }
            else if (this.sumOrder > 1000 && this.sumOrder <= 1000)
            {
                this.clientType = ClientType.Silver;
            }
            else if (this.sumOrder > 1000 && this.sumOrder <= 30000)
            {
                this.clientType = ClientType.Gold;
            }
            else
            {
                this.clientType = ClientType.StarPlatinum;
            }
        }

        public void Print()
        {
            WriteLine($"код клиента:{ codeClient}  \nФИО: {name}  \nадрес: {adress} \nтелефон: {phone}  \nколичество заказов клиентa: {countOrder}  \nобщая сумма заказовклиента: { sumOrder}$\nважность клиента = {clientType}\n\n");
        }
    }
}
