using healthscan_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace healthscan_BE.Handlers
{
    public interface IProductHandler
    {
        Task<Product> GetProductByBarcode(int barcodeId);
    }
}
