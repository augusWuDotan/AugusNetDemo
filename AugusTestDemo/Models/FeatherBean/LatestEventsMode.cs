using System.Collections.Generic;

namespace AugusTestDemo.Models.FeatherBean
{
    //最新活動 擺放模式
    public class LatestEventsMode
    {
        public int ID { get; set; }
        //模式說明 
        public string ModeMessage { get; set; }
        //2張圖像的規則(儲存使用)
        public string ModeRule { get; set; }
        //模式包含的圖像
        public List<LatestEventsImage> LatestEventsImages { get; set; }
    }
}