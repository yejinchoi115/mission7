using System;
using System.Collections.Generic;
using System.Linq;

namespace m7.Models
{
    public class Basket
    {
        //declare and initialize
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();
        public void AddItem(Book bk, int qty)
        {
            BasketLineItem line = Items
                .Where(p => p.Book.BookId == bk.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //calculate the totl price of the items in the basket
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }
    //just one item
    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
