using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Mission06_Fitzgerald.Models
{
    public class Movie
    {
        [Required]
        public int MovieID { get; set; }

        [ForeignKey("CategoryID")]
        public int? CategoryID { get; set; }
        public Categories? Category { get; set; }

        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }

    }
}
