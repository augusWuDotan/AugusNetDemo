using System.Collections.Generic;

namespace AugusTestDemo.Models.FeatherBean
{
    //客製化服務擺放模式
    public class CustomizedServiceMode
    {
        public int ID { get; set; }
        //模式說明 
        public string ModeMessage { get; set; }
        //8張圖像的規則(儲存使用)
        public string ModeRule { get; set; }
        //模式包含的圖像
        public List<CustomizedServiceImage> CustomizedServiceImages { get; set; }
    }
}