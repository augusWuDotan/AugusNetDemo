using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //(設計師手稿)(限制只有3張)
    public class DesignerManuscriptImage
    {
        public int ID { get; set; }
        //順序[0-2]
        public int DesignerManuscriptIndex { get; set; }
        //路徑
        public string Path { get; set; }
        //設計師手稿擺放模式ID
        public int DesignerManuscriptModeID { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
