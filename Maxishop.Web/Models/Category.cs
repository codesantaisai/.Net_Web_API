using System.ComponentModel.DataAnnotations;

namespace Maxishop.Web.Models
{
    public class Category
    {
        [Key]
       public int id { get; set; }
        [Required]
       public string name { get; set; }

    }
}
