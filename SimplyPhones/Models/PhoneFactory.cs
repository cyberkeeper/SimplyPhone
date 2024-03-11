using SimplyPhones.Interfaces;

namespace SimplyPhones.Models
{    
    /// <summary>
    /// Factory class. Creates phone instances. Using this so that default settings can be applied is some 
    /// attribute is not supplied. 
    /// </summary>
    public static class PhoneFactory
    {
        // If some attribute is empty or null use this instead.
        private static readonly string NOT_SUPPLIED = "Not supplied";

        // Default image to be used. This will hopefully be overwritten by the program with a proper image.
        private static readonly string DEFAULT_IMAGE = "/Resources/not-found.png";

        /// <summary>
        /// Simple method that creates a Phone instance and sets the default image to a common image.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="imagePath"></param>
        /// <param name="about"></param>
        /// <returns></returns>
        public static IPhone CreateBasicPhone(string model, string manufacturer, string about)
        {
            IPhone phone = new Phone(model, manufacturer, about);
            phone.SetObjectImage(DEFAULT_IMAGE);
            return phone;
        }
    }
}
