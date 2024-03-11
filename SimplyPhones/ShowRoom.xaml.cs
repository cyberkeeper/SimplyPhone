using SimplyPhones.Models;
using SimplyPhones.ViewModels;
using System.Windows;


namespace SimplyPhones
{
    /// <summary>
    /// Interaction logic for ShowRoom.xaml
    /// </summary>
    public partial class ShowRoom : Window
    {
        private WarehouseViewModel _whouseVM;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShowRoom()
        {
            InitializeComponent();
            //create new warehouse
            Warehouse warehouse = new Warehouse();
            //setup the view model
            _whouseVM = new WarehouseViewModel(warehouse);
            //set the data context
            DataContext = _whouseVM;
        }

        /// <summary>
        /// Press the button to open a new window and see more details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowStock_Click(object sender, RoutedEventArgs e)
        {
            StockViewModel selectedItem = (StockViewModel)ListInventory.SelectedItems[0];
            PhoneViewModel pVM = selectedItem.Item as PhoneViewModel;

            AvailableStock itemDetails = new AvailableStock(pVM);
            itemDetails.Owner = this;
            this.Hide();
            itemDetails.Show();
        }
    }
}
