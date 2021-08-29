using System;
namespace AugusTestDemo.Models.FeatherBean
{
    public class HomePage
    {
        public int ID { get; set; }

        //本季花色ID
        public int? ColorOfTheSeasonID { get; set; }
        //設計師手稿ID
        public int? DesignerManuscriptID { get; set; }
        //客製化服務ID
        public int? CustomizedServiceID { get; set; }
        //最新活動ID
        public int? LatestEventsID { get; set; }
        //品牌故事ID
        public int? BrandStoryID { get; set; }


        //本季花色 包含內容
        public ColorOfTheSeason ColorOfTheSeason { get; set; }
        //設計師手稿 包含內容
        public DesignerManuscript DesignerManuscript { get; set; }
        //客製化服務 包含內容
        public CustomizedService CustomizedService { get; set; }
        //最新活動 包含內容
        public LatestEvents LatestEvents { get; set; }
        //品牌故事 包含內容
        public BrandStory BrandStory { get; set; }

    }
}
