using healthscan_BE.Builder;
using healthscan_BE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace healthscan_BE.Mocks
{
    public static class ProductMock
    {
        public static void CreateMocks()
        {
            BuildMockIngredients();
            BuildMockProducts();
        }

        private static void BuildMockIngredients()
        {
            new IngredientBuilder("A", ToxicityLevels.None);
            new IngredientBuilder("B", ToxicityLevels.Low);
        }

        private static void BuildMockProducts()
        {
            throw new NotImplementedException();
        }
    }
}
