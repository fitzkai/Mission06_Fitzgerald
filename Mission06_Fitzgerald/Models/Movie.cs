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
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, 9999, ErrorMessage = "Enter a valid year")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }

    }
}
