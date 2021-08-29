using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    // (最新活動)(限制最多只有2張)
    public class LatestEventsImage
    {
        public int ID { get; set; }
        //路徑
        public string Path { get; set; }
        //最新活動擺放模式ID
        public int LatestEventsModeID { get; set; }
        //建立時間
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}