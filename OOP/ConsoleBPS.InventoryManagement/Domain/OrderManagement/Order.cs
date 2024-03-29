﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBPS.InventoryManagement.Domain.OrderManagement
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderFulfilmentDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public bool Fulfilled { get; set; } = false;

        public Order()
        {
            Id = new Random().Next(9999999);

            int numberOfSeconds = new Random().Next(100);
            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberOfSeconds);

            OrderItems = new List<OrderItem>();
        }

        public string ShowOrderDetails()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Order ID: {Id}");
            sb.AppendLine($"Order fulfilment date: {OrderFulfilmentDate.ToShortTimeString()}");

            if (OrderItems != null)
            {
                foreach (OrderItem item in OrderItems)
                {
                    sb.AppendLine($"{item.ProductId}. {item.ProductName}: {item.AmountOrdered}");
                }
            }

            return sb.ToString();
        }
    }
}
