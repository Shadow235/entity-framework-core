using EFJsonWithoutJSONColumn.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EFJsonWithoutJSONColumn.DataAccess;

public class TemplateDbContext : DbContext
{
	public DbSet<TemplateInstance> TemplateInstances { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlite("Data Source=Test.db");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<TemplateInstance>()
			.ToTable("TemplateInstances")
			.Property(t => t.Data)
			.HasConversion(
				v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
				v => JsonConvert.DeserializeObject<TemplateData>(v)
			);

		base.OnModelCreating(modelBuilder);
	}
}
