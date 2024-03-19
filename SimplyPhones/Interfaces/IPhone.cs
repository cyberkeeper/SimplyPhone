using System.Windows.Media.Imaging;

namespace SimplyPhones.Interfaces
{
    /// <summary>
    /// Interface that contains all everything that a phone needs to be a phone
    /// </summary>
    public interface IPhone
    {
        //General information about the phone
        string Model { get; }
        string Manufacturer { get; }
        string About { get; }
        //BitmapImage ObjectImage { get; }
        string ImagePath { get; }

        //Cost details
        int PayAsYouGo { get; set; }
        int SimFree { get; set; }

        //Monthly contract prices
        int ContractBelow800 { get; set; }
        int Contract800 { get; set; }

        //Set the image for the phone
        //void SetObjectImage(string imageLocation);

        //Short identifier for phone
        string ShortID { get; }
    }
}
