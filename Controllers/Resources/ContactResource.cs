using System.ComponentModel.DataAnnotations;

namespace ctrader.Controllers.Resources
{
    public class ContactResource
    {
        public string Name { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }
}