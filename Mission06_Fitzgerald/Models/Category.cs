using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Fitzgerald.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
