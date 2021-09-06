using System;
namespace AugusTestDemo.Models.FeatherBean
{
    //設計師
    public class Designer
    {
        public int ID { get; set; }
        public int ProductTypeID { get; set; }

        //設計師 產品型別(會包含產品)
        public ProductType ProductType { get; set; }
    }
}
