using System.ComponentModel.DataAnnotations;

namespace ItemApi.Data
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Error { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime When { get; set; }
        
    }
}
