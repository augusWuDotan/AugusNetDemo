using System;
namespace AugusTestDemo.Models.FeatherBean
{
    //設計師手稿
    public class DesignerManuscript
    {
        public int ID { get; set; }
        //設計師手稿模式ID
        public int DesignerManuscriptModeID { get; set; }
        //模式包含內容
        public DesignerManuscriptMode DesignerManuscriptMode { get; set; }
    }
}
