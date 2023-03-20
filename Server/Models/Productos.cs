using System.ComponentModel.DataAnnotations;

namespace Colmado.Server.Models;
public class Productos
{
    [Key]
    public int Id { get; set; }
    public string NombreP { get; set; } = null!;
    public decimal Costo { get; set; }
    public int Codigo { get; set; }
    public int Cantidad { get; set; }

}