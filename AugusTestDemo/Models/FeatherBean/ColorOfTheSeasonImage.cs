using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //(本季花色)(限制只有四張)
    public class ColorOfTheSeasonImage
    {
        public int ID { get; set; }
        //順序[0-3]
        public int ColorOfTheSeasonIndex { get; set; }
        //路徑
        public string Path { get; set; }
        //本季花色擺放模式ID
        public int ColorOfTheSeasonModeID { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
