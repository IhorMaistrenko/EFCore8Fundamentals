using PublisherData;

using PubContext _context = new();
QueryFilters();

void QueryFilters()
{
    var name = "Josie";
    var authors = _context.Authors
        .Where(a => a.FirstName == name)
        .ToList();
}