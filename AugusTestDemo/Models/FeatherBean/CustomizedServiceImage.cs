using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //(客製化服務)(限制只有8張)
    public class CustomizedServiceImage
    {
        public int ID { get; set; }
        //順序[0-7]
        public int CustomizedServiceIndex { get; set; }
        //路徑
        public string Path { get; set; }
        //設計師手稿擺放模式ID
        public int CustomizedServiceModeID { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}