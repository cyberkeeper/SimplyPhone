using SimplyPhones.Interfaces;

namespace SimplyPhones.Models
{
    /// <summary>
    /// Model. Class used to keep track of the number of items in stock.
    /// </summary>
    public class Stock : IStock
    {
        public Phone Item { get; set; }
        public int NumberInStock { get; set; }
        public string Status { get; }

        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="item"></param>
        /// <param name="number"></param>
        public Stock(Phone item, int number)
        {
            Item = item;
            NumberInStock = number;
        }
    }
}
