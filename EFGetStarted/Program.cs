// See https://aka.ms/new-console-template for more information

BloggingContext _db = new BloggingContext();

Console.WriteLine(_db.DbPath);

Blog b1 = new Blog { Url = "www.google.ca"};

//_db.Blogs.Add(b1);
//_db.SaveChanges();

Blog b2 =_db.Blogs.Find(1) ?? new();

//Console.WriteLine($"{b2.BlogId} -{b2.Url}");

Post p1 = new Post{Content = "nskdnskdnkdsnd",Title= "sdhidgsdbvj", };

b2.Posts.Add(p1);

_db.SaveChanges();
