using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    //(本季花色擺放模式)
    public class ColorOfTheSeasonMode
    {
        public int ID { get; set; }
        //模式說明 
        public string ModeMessage { get; set; }
        //四張圖像的規則(儲存使用)
        public string ModeRule { get; set; }
        //模式包含的圖像
        public List<ColorOfTheSeasonImage> ColorOfTheSeasonImages { get; set; }
    }
}
