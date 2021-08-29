using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models.FeatherBean
{
    public class FeatherImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
