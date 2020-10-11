
using Microsoft.EntityFrameworkCore;
namespace AngularUnit.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options)
		   : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<News> News { get; set; }

	}
}