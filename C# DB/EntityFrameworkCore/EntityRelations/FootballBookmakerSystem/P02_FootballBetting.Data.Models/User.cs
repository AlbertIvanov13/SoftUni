using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    using static Common.EntityValidation.User;
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(UsernameMaxLength)]
        public string Username { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Column(TypeName = BalanceColumnType)]
        public decimal Balance { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
           = new HashSet<Bet>();
    }
}