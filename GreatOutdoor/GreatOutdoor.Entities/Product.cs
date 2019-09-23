using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.GreatOutdoor.Entities
{
    /// <summary>
    /// Interface for Product Entity
    /// </summary>    
    public interface IProduct
    {
        Guid ProductID { get; set; }
        string ProductCategory { get; set; }
        string ProductDescription { get; set; }
        int ProductQuantity { get; set; }
        double ProductPrice { get; set; }
        DateTime CreationDateTime { get; set; }
        DateTime LastModifiedDateTime { get; set; }
    }
    /// <summary>
    /// Represents Product
    /// </summary>

    public class Product:IProduct
    {
        /* Auto-Implemented Properties*/
        [Required("Supplier ID can't be blank")]
        public Guid ProductID { get; set; }

        public string ProductCategory { get; set; }

        public string ProductDescription

           
        /* Constructor */
        public Product()
        {
            ProductID = default(Guid);
            ProductCategory = null;

        }



    }
}
