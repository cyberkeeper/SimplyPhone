using System.IO;
using System.Windows;

namespace SimplyPhones.Models
{
    /// <summary>
    /// Model. Class acts as a warehouse of all stock items.
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// list of all available stock in the inventory
        /// </summary>
        private List<Stock> Inventory { get;  set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Warehouse()
        {
            Inventory = new List<Stock>();
            LoadStockFromCSV("Resources/stock.csv");
        }

        /// <summary>
        /// Add items of stock to the warehouse
        /// </summary>
        /// <param name="item"></param>
        public void AddStock(Stock item)
        {
            Inventory.Add(item);
        }

        /// <summary>
        /// Return a list of what is currently in stock
        /// </summary>
        /// <returns></returns>
        public List<Stock> GetAvailableStock()
        {
            return Inventory.Where(stockItem => stockItem.NumberInStock > 0).ToList();
        }

        /// <summary>
        /// The Warehouse class is responsible for loading its data. Data is coming from a csv file.
        /// </summary>
        /// <param name="filePath"></param>
        private void LoadStockFromCSV(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Parse the CSV line and extract phone model, manufacturer, number in stock
                        string[] data = line.Split(',');
                        string model = data[0];
                        string manufacturer = data[1];
                        int numberInStock = int.Parse(data[2]);
                        string about = data[3];
                        string path = data[4];

                        // Create a Stock object and add it to the Inventory list
                        Phone p = new Phone(model, manufacturer, about);
                        //p.SetObjectImage(path);
                        p.ImagePath = path;
                        Stock stockItem = new Stock(p,numberInStock);
                        //Stock stockItem = new Stock(new Phone(model, manufacturer,about), numberInStock);
                        Inventory.Add(stockItem);
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Unable to load stock", "Error!", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
        }
    }
}
