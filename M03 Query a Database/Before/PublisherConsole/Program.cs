using PublisherData;
using PublisherDomain;

using PubContext _context = new();
// QueryFilters();

void QueryFilters()
{
    var name = "Josie";
    var authors = _context.Authors
        .Where(a => a.FirstName == name)
        .ToList();
}

// AddSomeMoreAuthors();

void AddSomeMoreAuthors()
{
    _context.Authors.AddRange(
        new Author { FirstName = "Rhoda", LastName = "Lerman" },
        new Author { FirstName = "Don", LastName = "Jones" },
        new Author { FirstName = "Jim", LastName = "Christopher" },
        new Author { FirstName = "Steven", LastName = "Haunts" }
    );
    _context.SaveChanges();
}

// SkipAndTakeAuthors();

void SkipAndTakeAuthors()
{
    var groupSize = 2;
    for (int i = 0; i < 5; i++)
    {
        var authors = _context.Authors
            .Skip(i * groupSize)
            .Take(groupSize)
            .ToList();
        Console.WriteLine($"Group {i + 1}:");
        foreach (var author in authors)
        {
            Console.WriteLine($"{author.FirstName} {author.LastName}");
        }
    }
}

SortAuthors();

void SortAuthors()
{
    var authorsByLastName = _context.Authors
        .OrderBy(a => a.LastName)
        .ThenBy(a => a.FirstName)
        .ToList();
    authorsByLastName.ForEach(a => Console.WriteLine($"{a.FirstName} {a.LastName}"));
}