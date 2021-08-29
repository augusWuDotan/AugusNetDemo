using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //產品
    public class Product
    {
        public int ID { get; set; }
        //產品規格 
        public string ProductRule { get; set; }
        //產品說明
        public string ProductInfo { get; set; }
        //產品說明
        public int ProductTypeID { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        //產品包含的圖片
        public List<FeatherImage> FeatherImages { get; set; }
    }
}
