using healthscan_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace healthscan_BE.Handlers
{
    public class ProductHandler : IProductHandler
    {
        public async Task<Product> GetProductByBarcode(int barcodeId)
        {
            return null;
        }
    }
}
