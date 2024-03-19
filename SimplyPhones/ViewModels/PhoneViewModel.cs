using SimplyPhones.Models;
using System.CodeDom;
using System.IO;
using System.Windows.Media.Imaging;

namespace SimplyPhones.ViewModels
{
    /// <summary>
    /// ViewModel. Expose the phone class to the GUI.
    /// </summary>
    public class PhoneViewModel
    {
        // if problem with image then use this one instead.
        private readonly string DEFAULT_MISSING_IMAGE_PATH = "/Resources/not-found.png";

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string About { get; set; }
        public string ShortId { get; set; }

        public string? ImagePath { get; set; }
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
            ShortId = phone.ShortID; 
            ImagePath = phone.ImagePath;
            PhoneImage = GetImage(ImagePath);

            // Assuming these price properties are for display purposes only
            PayAsYouGoPrice = phone.PayAsYouGo;
            SimFreePrice = phone.SimFree;
            ContractBelow800Price = phone.ContractBelow800;
            Contract800Price = phone.Contract800;
        }

        /// <summary>
        /// Check if expected image is present, if not return a default image
        /// </summary>
        /// <returns></returns>        
        private BitmapImage? GetImage(string path)
        {
            FileInfo fileInfo = new FileInfo(path);

            BitmapImage ObjectImage = new BitmapImage();
            ObjectImage.BeginInit();
            ObjectImage.UriSource = new Uri(path, UriKind.Relative);
            ObjectImage.EndInit();       

            return ObjectImage;
        }
    }
}
