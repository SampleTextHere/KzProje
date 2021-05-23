using Navigation2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Navigation2.Models
{
    public static class ProductSeedData
    {
        public static void EnsureSeedData(this ProductContext db)
        {
            if (!db.Products.Any())
            {
                foreach (var item in DataHolder.Products )
                {
                    db.Products.Add(item);
                }
                db.SaveChanges();
            }
        }
    }
}
