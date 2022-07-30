using PetStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Logic
{
    internal interface IProductLogic
    {
        /// <summary>
        /// Add a product to the stores inventory
        /// </summary>
        /// <param name="product">The product that will be added.  It can be a derived type of Product</param>
        public void AddProduct(Product product);

        /// <summary>
        /// Get all the products for the store
        /// </summary>
        public List<Product> GetAllProducts();

        /// <summary>
        /// Gets a dog leash by the name of the product
        /// </summary>
        /// <param name="name">The name given to the product.  It can include spaces</param>
        public DogLeash GetDogLeashByName(string name);

        /// <summary>
        /// Get all in stock products
        /// </summary>
        /// <returns>The names of the in stock products</returns>
        public List<string> GetOnlyInStockProducts();

        /// <summary>
        /// Returns the sum of the prices for all in stock products
        /// </summary>
        /// <returns>Dollar amount</returns>
        public decimal GetTotalPriceOfInventory();
    }
}
