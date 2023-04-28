using System.ComponentModel.DataAnnotations;

namespace projectef.Models;

public class Category
{
    [Key]
    public Guid categoryId { get; set; }
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Task> Tasks { get; set; }
}