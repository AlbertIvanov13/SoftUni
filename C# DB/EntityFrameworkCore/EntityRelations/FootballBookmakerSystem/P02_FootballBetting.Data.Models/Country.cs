using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    using static Common.EntityValidation.Country;
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Town> Towns { get; set; }
          = new HashSet<Town>();
    }
}