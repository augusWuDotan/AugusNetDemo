using System;
namespace AugusTestDemo.Models.FeatherBean
{
    //客製化服務
    public class CustomizedService
    {
        public int ID { get; set; }
        //客製化服務模式ID
        public int CustomizedServiceModeID { get; set; }
        //模式包含內容
        public CustomizedServiceMode CustomizedServiceMode { get; set; }
    }
}
