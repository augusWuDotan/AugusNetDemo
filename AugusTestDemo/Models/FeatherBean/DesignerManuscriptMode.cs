using System;
using System.Collections.Generic;

namespace AugusTestDemo.Models.FeatherBean
{
    //設計師手稿擺放模式
    public class DesignerManuscriptMode
    {
        public int ID { get; set; }
        //模式說明 
        public string ModeMessage { get; set; }
        //三張圖像的規則(儲存使用)
        public string ModeRule { get; set; }
        //模式包含的圖像
        public List<DesignerManuscriptImage> DesignerManuscriptImages { get; set; }
    }
}
