using System.Windows.Media.Imaging;

namespace SimplyPhones.Models
{
    /// <summary>
    /// Model. Cass that represents a phone.
    /// </summary>
    public class Phone : Interfaces.IPhone
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string About { get; }
        //public BitmapImage? ObjectImage { get; private set; }
        public string ImagePath { get; set; }
        public int PayAsYouGo { get; set; }
        public int SimFree { get; set; }
        public int ContractBelow800 { get; set; }
        public int Contract800 { get; set; }
        public string ShortID { get => Manufacturer + "_" + Model; }

        /// <summary>
        /// Constructor. Doesn't take the about parameter. Calls the 3 parameter constructor and passed an
        /// empty string for the about parameter.
        /// </summary>
        /// <param name="model">Model name of the phone</param>
        /// <param name="manufacturer">Manufacturer of the phone</param>                
        public Phone(string model, string manufacturer) : this (model, manufacturer, "")
        {            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model">Model name of the phone</param>
        /// <param name="manufacturer">Manufacturer of the phone</param>        
        /// <param name="about">Additional information about the phone</param>
        public Phone(string model, string manufacturer, string about)
        {
            Model = model;
            Manufacturer = manufacturer;
            About = about;
        }

        /// <summary>
        /// Set the upfront price for the phone
        /// </summary>
        /// <param name="payg">Upfront PAYG price</param>
        /// <param name="free">Upfront SimFree price</param>
        public void SetUpFrontPrice(int payg, int free)
        {
            PayAsYouGo = payg;
            SimFree = free;
        }

        /// <summary>
        /// Set the monthly contract prices
        /// </summary>
        /// <param name="above8">Monthly contract price for Simply800 and above</param>
        /// <param name="below">Monthly contract price or other contracts </param>
        public void SetMonthlyContractPrice(int above8, int below)
        {
            Contract800 = above8;
            ContractBelow800 = below;
        }

        /// <summary>
        /// Set the image for the phone.
        /// </summary>
        /// <param name="location"></param>
       /* public void SetObjectImage(string location)
        {
            ObjectImage = new BitmapImage();
            ObjectImage.BeginInit();
            ObjectImage.UriSource = new Uri(location, UriKind.Relative);
            ObjectImage.EndInit();
        }*/
    }
}
