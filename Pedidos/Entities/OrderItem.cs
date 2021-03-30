﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Product.Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity
                + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);                ;
        }
    }
}
