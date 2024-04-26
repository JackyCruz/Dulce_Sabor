using Microsoft.EntityFrameworkCore;
namespace Dulce_Sabor.Models
{
	public class dulceSaborDbContext : DbContext
	{
		public dulceSaborDbContext(DbContextOptions options) : base(options) 
		{
		}

		public DbSet<mesas> mesas { get; set; }
		public DbSet<Cuenta> Cuenta { get; set; }
		public DbSet<platos> platos { get; set; }
		public DbSet<Detalle_Pedido> Detalle_Pedido { get; set; }
		public DbSet<comentarios_detalle> comentarios_detalle { get; set; }

	}
}
