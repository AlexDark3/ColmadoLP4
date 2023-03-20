using System.ComponentModel.DataAnnotations;

namespace Colmado.Server.Models;
public class Listaventas
{
    [Key]
    public int Id { get; set; }
    public string NombreC { get; set; } = null!;
    public string NombreP { get; set; } = null!;
    public decimal Costo { get; set; }
    public int Cantidad { get; set; }
    public decimal Total { get; set; }
    public DateTime fecha { get; set; }
}
