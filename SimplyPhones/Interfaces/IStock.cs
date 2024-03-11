using SimplyPhones.Models;

namespace SimplyPhones.Interfaces
{
    /// <summary>
    /// Interface that contains all everything that a showroom or warehouse needs to know about
    /// </summary>
    public interface IStock
    {
        public Phone Item { get; set; }
        public int NumberInStock { get; set; }
        public string Status { get;}
    }
}
