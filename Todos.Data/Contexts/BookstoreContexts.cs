namespace Todos.Data.Contexts;

public class DataContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Author => Set<Author>();
    public DbSet<Publisher> Publisher => Set<Publisher>();

    public DbSet<AuthorBook> AuthorBooks => Set<AuthorBook>();
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder Builder)
    {
        base.OnModelCreating(Builder);
        Builder.Entity<AuthorBook>()
        .HasKey(tt => new { tt.AuthorId, tt.BookId });
    }




}