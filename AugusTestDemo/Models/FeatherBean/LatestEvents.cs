using System;
namespace AugusTestDemo.Models.FeatherBean
{
    //最新活動
    public class LatestEvents
    {
        public int ID { get; set; }
        //最新活動模式ID
        public int LatestEventsModeID { get; set; }
        //模式包含內容
        public LatestEventsMode LatestEventsMode { get; set; }
    }
}
