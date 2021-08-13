using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.Entities
{
    public class Prd_Detail
    {

        public int Prd_Detail_Id { get; set; }
        public float Prd_Detail_Price { get; set; }
        public string Prd_Detail_Image { get; set; }
        public string Prd_Detail_Descriptions { get; set; }
        public int Prd_Detail_Quantity { get; set; }
        public string Prd_Detail_Date { get; set; }
        public virtual Product Product { get; set; }
    }
}
