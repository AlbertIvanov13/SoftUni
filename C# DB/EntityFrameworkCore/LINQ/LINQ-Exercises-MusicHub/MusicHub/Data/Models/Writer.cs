using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    using static Common.EntityValidation.Writer;
    public class Writer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public string? Pseudonym  { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
             = new HashSet<Song>();
    }
}