using System.ComponentModel.DataAnnotations;

namespace CIS296FinalProject.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public required ICollection<Album> Albums { get; set; }
    }
}
