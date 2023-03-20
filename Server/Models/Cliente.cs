using System.ComponentModel.DataAnnotations;

namespace Colmado.Server.Models;
public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string Consetraseña { get; set; } = null!;

}