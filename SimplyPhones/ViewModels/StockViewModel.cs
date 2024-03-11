using SimplyPhones.Models;

namespace SimplyPhones.ViewModels
{
    /// <summary>
    /// ViewModel. Expose the Stock class to the GUI.
    /// </summary>
    public class StockViewModel
    {
        //make static as the same message should be used for every stock item
        private static readonly string OUT_OF_STOCK = "Out of stock";
        //make static as the same message should be used for every stock item
        private static readonly string AVAILABLE = "Available";

        public PhoneViewModel Item { get; set; }
        public int NumberInStock { get; set; }

        /// <summary>
        /// Return a status that represents how many of the item are in stock. (Uses ternary format)
        /// </summary>
        public string AvailabilityStatus { get { return (NumberInStock > 0) ? AVAILABLE : OUT_OF_STOCK; } }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="stock"></param>
        public StockViewModel(Stock stock)
        {
            // Convert Phone to PhoneViewModel
            Item = new PhoneViewModel(stock.Item); 
            NumberInStock = stock.NumberInStock;            
        }
    }
}
