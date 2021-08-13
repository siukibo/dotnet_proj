using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Entities
{
    public class Product
    {   
        public int Product_Id { get; set; }
        public int Category_Id { get; set; }
        public int Brand_Id { get; set; }
        public int Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Prd_Detail Prd_Detail { get; set; }



    }
}
