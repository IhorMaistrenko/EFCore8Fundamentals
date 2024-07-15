
using PublisherData;
using PublisherDomain;

using (PubContext context = new())
{
    context.Database.EnsureCreated();
}

GetAuthors();
//AddAuthor();
GetAuthors();

void AddAuthor()
{
    using var context = new PubContext();
    var author = new Author { FirstName = "Ryan", LastName = "Gosling" };
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }

}