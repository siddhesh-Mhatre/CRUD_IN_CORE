using Microsoft.EntityFrameworkCore;

namespace CRUD_IN_CORE.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
		{

		}
		public DbSet<CRUD_IN_CORE.Models.Car> cars { get; set; }
	
	}
}
