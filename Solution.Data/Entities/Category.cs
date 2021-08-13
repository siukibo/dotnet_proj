using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Entities
{
    public class Category  {   
        public int Category_Id { get; set; }
        public string Category_Name{ get; set; }
        public string Category_Descriptions { get; set; }
        public string Category_Image { get; set; }
        public virtual List<Product> Product { get; set; }




    }
}
