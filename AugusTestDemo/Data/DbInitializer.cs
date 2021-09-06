using System;
using System.Linq;
using AugusTestDemo.Models.FeatherBean;

namespace AugusTestDemo.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyDatabaseContext context)
        {

            //本季花色 預設
            if (!context.ColorOfTheSeason.Any())
            {
                //建立預設模式
                var ColorOfTheSeasonModes = new ColorOfTheSeasonMode[]
                {
                    new ColorOfTheSeasonMode
                    {
                        ModeMessage = "本季花色 第一種模式",
                        ModeRule = "本季花色 第一種模式規則"
                    },
                    new ColorOfTheSeasonMode
                    {
                        ModeMessage = "本季花色 第二種模式",
                        ModeRule = "本季花色 第二種模式規則"
                    }
                };

                foreach (ColorOfTheSeasonMode mode in ColorOfTheSeasonModes)
                {
                    context.ColorOfTheSeasonModes.Add(mode);
                }
                context.SaveChanges();

                //建立預設圖像
                var ColorOfTheSeasonImages = new ColorOfTheSeasonImage[]
                {
                    new ColorOfTheSeasonImage
                    {
                        ColorOfTheSeasonIndex = 0,
                        Path = "",
                        ColorOfTheSeasonModeID = ColorOfTheSeasonModes.Single(i=> i.ModeMessage == "本季花色 第一種模式").ID,
                        CreatedDate = DateTime.Now
                    },
                     new ColorOfTheSeasonImage
                    {
                        ColorOfTheSeasonIndex = 1,
                        Path = "",
                        ColorOfTheSeasonModeID = ColorOfTheSeasonModes.Single(i=> i.ModeMessage == "本季花色 第一種模式").ID,
                        CreatedDate = DateTime.Now
                    },
                      new ColorOfTheSeasonImage
                    {
                        ColorOfTheSeasonIndex = 2,
                        Path = "",
                        ColorOfTheSeasonModeID = ColorOfTheSeasonModes.Single(i=> i.ModeMessage == "本季花色 第一種模式").ID,
                        CreatedDate = DateTime.Now
                    },
                       new ColorOfTheSeasonImage
                    {
                        ColorOfTheSeasonIndex = 3,
                        Path = "",
                        ColorOfTheSeasonModeID = ColorOfTheSeasonModes.Single(i=> i.ModeMessage == "本季花色 第一種模式").ID,
                        CreatedDate = DateTime.Now
                    }
                };

                foreach (ColorOfTheSeasonImage image in ColorOfTheSeasonImages)
                {
                    context.ColorOfTheSeasonImages.Add(image);
                }
                context.SaveChanges();


                //建立預設本季花色
                var ColorOfTheSeason = new ColorOfTheSeason
                {
                    ColorOfTheSeasonModeID = ColorOfTheSeasonModes.Single(i => i.ModeMessage == "本季花色 第一種模式").ID
                };
                context.ColorOfTheSeason.Add(ColorOfTheSeason);
                context.SaveChanges();
            }

            //客製化服務 預設
            if (!context.CustomizedService.Any())
            {
                //建立預設模式
                var mode = new CustomizedServiceMode
                {
                    ModeMessage = "客製化服務 第一種模式",
                    ModeRule = "客製化服務 第一種模式規則"
                };
                context.CustomizedServiceModes.Add(mode);
                context.SaveChanges();

                //建立預設圖像
                var CustomizedServiceImages = new CustomizedServiceImage[]
                {
                    new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 0,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                     new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 1,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                      new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 2,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                       new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 3,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                       new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 4,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                     new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 5,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                      new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 6,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                       new CustomizedServiceImage
                    {
                        CustomizedServiceIndex = 7,
                        Path = "",
                        CustomizedServiceModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    }
                };

                foreach (CustomizedServiceImage image in CustomizedServiceImages)
                {
                    context.CustomizedServiceImages.Add(image);
                }
                context.SaveChanges();


                //建立預設 客製化服務
                var CustomizedService = new CustomizedService
                {
                    CustomizedServiceModeID = mode.ID
                };
                context.CustomizedService.Add(CustomizedService);
                context.SaveChanges();
            }

            //設計師手稿 預設
            if (!context.DesignerManuscript.Any())
            {
                //建立預設模式
                var mode = new DesignerManuscriptMode
                {
                    ModeMessage = "設計師手稿 第一種模式",
                    ModeRule = "設計師手稿 第一種模式規則"
                };
                context.DesignerManuscriptModes.Add(mode);
                context.SaveChanges();

                //建立預設圖像
                var DesignerManuscriptImages = new DesignerManuscriptImage[]
                {
                    new DesignerManuscriptImage
                    {
                        DesignerManuscriptIndex = 0,
                        Path = "",
                        DesignerManuscriptModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                     new DesignerManuscriptImage
                    {
                        DesignerManuscriptIndex = 1,
                        Path = "",
                        DesignerManuscriptModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    },
                      new DesignerManuscriptImage
                    {
                        DesignerManuscriptIndex = 2,
                        Path = "",
                        DesignerManuscriptModeID = mode.ID,
                        CreatedDate = DateTime.Now
                    }
                };

                foreach (DesignerManuscriptImage image in DesignerManuscriptImages)
                {
                    context.DesignerManuscriptImages.Add(image);
                }
                context.SaveChanges();


                //建立預設 設計師手稿
                var DesignerManuscript = new DesignerManuscript
                {
                    DesignerManuscriptModeID = mode.ID
                };
                context.DesignerManuscript.Add(DesignerManuscript);
                context.SaveChanges();
            }

            //最新活動 預設
            if (!context.LatestEvents.Any())
            {
                //建立預設模式
                var mode = new LatestEventsMode
                {
                    ModeMessage = "最新活動 第一種模式",
                    ModeRule = "最新活動 第一種模式規則"
                };
                context.LatestEventsModes.Add(mode);
                context.SaveChanges();

                //不建立預設圖像

                //建立預設 客製化服務
                var LatestEvents = new LatestEvents
                {
                    LatestEventsModeID = mode.ID
                };
                context.LatestEvents.Add(LatestEvents);
                context.SaveChanges();
            }

            //品牌故事 預設
            if (!context.BrandStory.Any())
            {
                //建立預設 客製化服務
                var BrandStory = new BrandStory
                {
                    BrandStoryImagePath = "",
                    BrandStoryIntroduction = ""
                };
                context.BrandStory.Add(BrandStory);
                context.SaveChanges();
            }

            //主畫面取得
            if (!context.HomePage.Any())
            {
                var ColorOfTheSeason = context.ColorOfTheSeason.Single();
                var CustomizedService = context.CustomizedService.Single();
                var DesignerManuscript = context.DesignerManuscript.Single();
                var LatestEvents = context.LatestEvents.Single();
                var BrandStory = context.BrandStory.Single();

                var HomePage = new HomePage
                {
                    ColorOfTheSeasonID = ColorOfTheSeason.ID,
                    CustomizedServiceID = CustomizedService.ID,
                    DesignerManuscriptID = DesignerManuscript.ID,
                    LatestEventsID = LatestEvents.ID,
                    BrandStoryID = BrandStory.ID
                };
                context.HomePage.Add(HomePage);
                context.SaveChanges();
            }

            //產品型別 預設
            if (!context.ProductTypes.Any())
            {
                var ProductTypes = new ProductType[]
                {
                    new ProductType
                    {
                        TypeName = "本季花色布料",
                        isShowProductInfo = false,
                        isConnectStore = true,
                        CreatedDate = DateTime.Now
                    },
                    new ProductType
                    {
                        TypeName = "本季花色產品",
                        isShowProductInfo = true,
                        isConnectStore = true,
                        CreatedDate = DateTime.Now
                    },
                    new ProductType
                    {
                        TypeName = "吳翠茵設計師",
                        isShowProductInfo = false,
                        isConnectStore = false,
                        CreatedDate = DateTime.Now
                    },
                    new ProductType
                    {
                        TypeName = "客製化服務",
                        isShowProductInfo = true,
                        isConnectStore = false,
                        CreatedDate = DateTime.Now
                    }
                };

                foreach (ProductType type in ProductTypes)
                {
                    context.ProductTypes.Add(type);
                }
                context.SaveChanges();


                //設計師預設
                var Designer = new Designer
                {
                    ProductTypeID = ProductTypes.Single(i => i.TypeName == "吳翠茵設計師").ID
                };
                context.Designers.Add(Designer);
                context.SaveChanges();
            }
        }

    }
}
