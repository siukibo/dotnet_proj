using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Entities
{
    public class Brand
    {
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public string Brand_Descriptions { get; set; }
        public string Brand_Image { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}
