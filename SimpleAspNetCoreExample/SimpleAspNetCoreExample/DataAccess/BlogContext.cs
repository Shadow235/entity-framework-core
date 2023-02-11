using Microsoft.EntityFrameworkCore;
using SimpleAspNetCoreExample.Models;

namespace SimpleAspNetCoreExample.DataAccess
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions<BlogContext> options) : base(options){ }

		public DbSet<Post> Posts { get; set; }
	}
}
