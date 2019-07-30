using healthscan_BE.Models;
using System.Collections.Generic;

namespace healthscan_BE.Builder
{
    public class ProductsBuilder : ContextDB
    {
        public ProductsBuilder(string Name, int BarcodeNumber, IEnumerable<Ingredient> Ingredients)
        {
            var product = new Product
            {
                Name = Name,
                BarcodeNumber = BarcodeNumber,
                ListIngredients = Ingredients
            };

            using (var context = new ContextDB())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
