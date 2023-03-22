using EFJsonWithoutJSONColumn.DataAccess;
using EFJsonWithoutJSONColumn.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

using var db = new TemplateDbContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();

db.TemplateInstances.Add(new TemplateInstance
{
	Name = "test",
	Data = new BtwTemplateData
	{
		Path = "Path",
		Paramters = new()
		{
			["Key"] = "value1",
		}
	}
});

db.SaveChanges();

var result = db.TemplateInstances.SingleOrDefault();


Console.ReadKey();