using System.ComponentModel.DataAnnotations;

namespace Fantasy.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    [MaxLength(100, ErrorMessage = "El máximo tamaño del campo {0} es {1} caractéres")]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    public string Name { get; set; } = null!;
}