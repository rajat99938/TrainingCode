using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class DataModel
    {
    }

    public class userLoginDetails_result
    {
        [Key]
        public int? uid { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
