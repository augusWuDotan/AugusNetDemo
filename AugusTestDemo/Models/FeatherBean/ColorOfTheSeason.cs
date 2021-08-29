using System;
namespace AugusTestDemo.Models.FeatherBean
{
    //本季花色
    public class ColorOfTheSeason
    {
        public int ID { get; set; }
        //本季花色擺放模式ID
        public int ColorOfTheSeasonModeID { get; set; }
        //模式包含內容
        public ColorOfTheSeasonMode ColorOfTheSeasonMode { get; set; }
    }
}
