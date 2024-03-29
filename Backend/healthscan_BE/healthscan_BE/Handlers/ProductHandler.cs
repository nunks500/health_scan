﻿using healthscan_BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace healthscan_BE.Handlers
{
    public class ProductHandler : IProductHandler
    {
        public Product GetProductByBarcode(int barcodeId)
        {
            using (var context = new ContextDB())
            {
                return context.Products
                    .Where(s => s.BarcodeNumber == barcodeId)
                    .FirstOrDefault();
            }
        }
    }
}
