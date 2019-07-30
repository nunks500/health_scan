using healthscan_BE.Enums;
using healthscan_BE.Models;

namespace healthscan_BE.Builder
{
    public class IngredientBuilder
    {
        public IngredientBuilder(string Name, ToxicityLevels ToxicityLevel)
        {
            var Ingredient = new Ingredient
            {
                Name = Name,
                ToxicityLevel = ToxicityLevel
            };

            using (var context = new ContextDB())
            {
                context.Ingredients.Add(Ingredient);
                context.SaveChanges();
            }
        }
    }
}
