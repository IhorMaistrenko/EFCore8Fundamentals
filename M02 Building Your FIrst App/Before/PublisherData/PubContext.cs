
using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;

public class PubContext: DbContext
{
    public DbSet<Author> Authors { get; set; }  
    public DbSet<Book> Books { get; set; }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database = PubDatabase;User ID=;Password=;TrustServerCertificate=YES");
    }
}
