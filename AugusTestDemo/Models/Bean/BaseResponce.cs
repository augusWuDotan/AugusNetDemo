using System;
using System.Runtime.Serialization;

namespace AugusTestDemo.Models.Bean
{
    /// <summary>
    /// 反饋
    /// </summary>
    public class BaseResponce<T>
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }
        [DataMember(Name = "message")]
        public string Message { get; set; }
        [DataMember(Name = "data")]
        public T Data { get; set; }
        [DataMember(Name = "dateTime")]
        public string DateTime { get; set; }
    }
}
