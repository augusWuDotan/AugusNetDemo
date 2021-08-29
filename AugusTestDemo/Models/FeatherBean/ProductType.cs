using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //產品類別
    public class ProductType
    {
        public int ID { get; set; }
        //類別描述 
        public string TypeName { get; set; }
        //是否可以顯示產品詳情
        public Boolean isShowProductInfo { get; set; }
        //是否顯示賣場(0,1)
        public Boolean isConnectStore { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public List<Product> Products { get; set; }
    }
}
