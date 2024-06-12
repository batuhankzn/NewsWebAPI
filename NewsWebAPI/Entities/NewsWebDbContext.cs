using Microsoft.EntityFrameworkCore;

namespace NewsWebAPI;

public class NewsWebDbContext : DbContext
{
    
    public NewsWebDbContext(DbContextOptions<NewsWebDbContext> options) : base(options)
    {
    }

    public required DbSet<News> Title { get; set; }
    public required DbSet<News> Content { get; set; }
    public  DbSet<News> Date { get; set; }
    public DbSet<News> News { get; set; }

}
