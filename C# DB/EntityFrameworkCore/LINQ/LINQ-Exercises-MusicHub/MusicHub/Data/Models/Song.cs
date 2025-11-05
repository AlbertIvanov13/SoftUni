using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    using static Common.EntityValidation.Song;
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        //Required by default
        public TimeSpan Duration { get; set; }

        //Required by default
        public DateTime CreatedOn { get; set; }

        //Required by default
        public Genre Genre { get; set; }

        [ForeignKey(nameof(Album))]
        public int? AlbumId { get; set; }

        public virtual Album? Album { get; set; }

        [ForeignKey(nameof(Writer))]
        public int WriterId { get; set; }

        public virtual Writer Writer { get; set; } = null!;

        //Required by default
        [Column(TypeName = PriceDateType)]
        public decimal Price { get; set; }

        public virtual ICollection<SongPerformer> SongPerformers { get; set; }
            = new HashSet<SongPerformer>();
    }
}