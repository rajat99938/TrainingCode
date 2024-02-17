using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class UserPersonalInformationModel
    {
        public string? UPI_firstname { get; set; }
        public string? UPI_lastname { get; set; }
        public long? UPI_mobileNumber { get; set; }
        public string? UPI_email { get; set; }

        [Key]
        public int? UPI_id { get; set; }
    }
}
