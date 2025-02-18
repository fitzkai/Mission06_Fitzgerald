using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Fitzgerald.Models
{
    public class Categories
    {
        [Required]
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }

    }
}
