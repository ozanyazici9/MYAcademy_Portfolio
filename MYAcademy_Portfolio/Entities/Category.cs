using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Category
{
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Kategori adı en fazla 100 karakter olabilir.")]
    public string CategoryName { get; set; }
    public List<Project> Projects { get; set; } = new List<Project>();
}
