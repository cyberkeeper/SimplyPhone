using SimplyPhones.Models;
using SimplyPhones.ViewModels;
using System.Windows;

namespace SimplyPhones
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AvailableStock : Window
    {
        public AvailableStock(PhoneViewModel pVM)
        {
            InitializeComponent();


            //set ViewModel to use
            DataContext = pVM;
            try
            {
                PhoneImage.Source = pVM.PhoneImage;
                // p.SetObjectImage("/Resources/fruitPhone.png");
                //PhoneImage.Source = p.ObjectImage;
                //PhoneImage.Source = new BitmapImage(new Uri("E:\\sourceCode\\CSharp\\SimplyDemo\\SimplyPhones/alienzap.png"));                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to find image", "Missing resource", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}