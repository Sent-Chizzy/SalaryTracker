using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaryTracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="This Field cannot be Empty.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; } = "Expense";
        [NotMapped]
        public string? TitleWithIcon { get 
            {
                return this.Icon + " " + this.Title;
            } }
    }
}
