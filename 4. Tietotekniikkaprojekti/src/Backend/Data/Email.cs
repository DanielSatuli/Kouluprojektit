using System.ComponentModel.DataAnnotations;

namespace ItemApi.Data
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        
    }
}
