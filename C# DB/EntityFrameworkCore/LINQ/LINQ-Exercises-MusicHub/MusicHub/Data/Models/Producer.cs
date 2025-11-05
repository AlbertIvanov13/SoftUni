using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models
{
    using static Common.EntityValidation.Producer;
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public string? Pseudonym  { get; set; }

        public string? PhoneNumber  { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
            = new HashSet<Album>();
    }
}