using System.ComponentModel.DataAnnotations;

namespace CIS296FinalProject.Models
{
    public class Song
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public int AlbumId { get; set; }
        public required Album Album { get; set; }

    }
}
