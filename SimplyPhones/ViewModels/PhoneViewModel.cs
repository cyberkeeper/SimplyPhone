using SimplyPhones.Models;
using System.Windows.Media.Imaging;

namespace SimplyPhones.ViewModels
{
    /// <summary>
    /// ViewModel. Expose the phone class to the GUI.
    /// </summary>
    public class PhoneViewModel
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string About { get; set; }
        public string ShortId { get; set; } // Assuming this property doesn't require recalculation

        public string? ImagePath { get; set; } // Assuming you want a separate path property instead of BitmapImage
        public BitmapImage? PhoneImage { get; private set; }

        public int PayAsYouGoPrice { get; set; }
        public int SimFreePrice { get; set; }
        public int ContractBelow800Price { get; set; }
        public int Contract800Price { get; set; }

        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="phone"></param>
        public PhoneViewModel(Phone phone)
        {
            Model = phone.Model;
            Manufacturer = phone.Manufacturer;
            About = phone.About;
            ShortId = phone.ShortID; // Assuming this property doesn't require recalculation
            ImagePath = phone.ObjectImage?.UriSource?.ToString(); // Extract path from BitmapImage (if set)
            PhoneImage = phone.ObjectImage;

            // Assuming these price properties are for display purposes only
            PayAsYouGoPrice = phone.PayAsYouGo;
            SimFreePrice = phone.SimFree;
            ContractBelow800Price = phone.ContractBelow800;
            Contract800Price = phone.Contract800;
        }
    }
}
