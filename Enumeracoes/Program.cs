using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            //Convert to string
            string txt = OrderStatus.PendingPayment.ToString();

            //Convert to Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
            Console.WriteLine(order);
        }
    }
}
