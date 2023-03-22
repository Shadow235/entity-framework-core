using SimpleEFCoreConsoleExample;

using var db = new BlogContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();

db.Posts.Add(new Post { Title = "Topic 1", Content = "" });

db.SaveChanges();

var topic1 = db.Posts.FirstOrDefault(p => p.Title == "Topic 1");

Console.ReadKey();