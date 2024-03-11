using SimplyPhones.Models;

namespace SimplyPhones.ViewModels
{
    /// <summary>
    /// ViewModel. Expose the Warehouse class to the GUI.
    /// </summary>
    public class WarehouseViewModel
    {
        public List<StockViewModel> AvailableInventory { get; private set; }

        public WarehouseViewModel(Warehouse warehouse)
        {
            AvailableInventory = warehouse.GetAvailableStock()
                .Select(stockItem => new StockViewModel(stockItem))
                .ToList();
        }
    }
}
