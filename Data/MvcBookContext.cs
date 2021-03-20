using Microsoft.EntityFrameworkCore;
using BookShopDotNet1.Models;


namespace BookShopDotNet1.Data
{

    public class MvcBooksContext : DbContext
    {
        public MvcBooksContext(DbContextOptions<MvcBooksContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
    }
}
