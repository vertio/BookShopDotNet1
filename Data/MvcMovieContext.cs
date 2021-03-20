using Microsoft.EntityFrameworkCore;
using BookShopDotNet1.Models;


namespace BookShopDotNet1.Data
{
        public class MvcMovieContext : DbContext
        {
            public MvcMovieContext(DbContextOptions<MvcMovieContext> options) 
                : base(options)
            { 
            }
            public DbSet<Movie> Movie { get; set; }
        }   
}
