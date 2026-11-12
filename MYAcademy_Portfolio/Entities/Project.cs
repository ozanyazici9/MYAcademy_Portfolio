using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Project
{
    public int ProjectId { get; set; }

    [Required(ErrorMessage = "Proje adı boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Proje adı en fazla 100 karakter olabilir.")]
    [MinLength(3, ErrorMessage = "Proje adı en az 3 karakter olmalı.")]
    public string ProjectName { get; set; } = null!;

    [Required(ErrorMessage = "Proje görseli boş bırakılamaz.")]
    public string ImageUrl { get; set; } = null!;

    [Required(ErrorMessage = "Proje açıklaması boş bırakılamaz.")]
    [MaxLength(800, ErrorMessage = "Proje açıklaması en fazla 800 karakter olabilir.")]
    [MinLength(10, ErrorMessage = "Proje açıklaması en az 10 karakter olmalı.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Proje GitHub URL'si boş bırakılamaz.")]
    public string GithubUrl { get; set; } = null!;

    [Required(ErrorMessage = "Proje canlı demo URL'si boş bırakılamaz.")]
    public string LiveDemoUrl { get; set; } = null!;
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public ICollection<Technology> Technologies { get; set; } = new List<Technology>();
}
