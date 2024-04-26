using System.ComponentModel.DataAnnotations;

namespace Dulce_Sabor.Models
{
	public class comentarios_detalle
	{
		[Key]
		public int Id_comentario { get; set; }
		public int Id_DetalleCuenta { get; set; }
		public string? Comentario { get; set; }
	}
}
