using System.ComponentModel.DataAnnotations;

namespace CIS296FinalProject.Models
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public int ArtistId { get; set; }
        public required Artist Artist { get; set; }
        public required ICollection<Song> Songs { get; set; }
        public DateTime ReleaseDate { get; internal set; }
    }
}
       