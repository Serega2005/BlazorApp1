namespace BlazorApp1.Data;

using Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    public AppDbContext(
        DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
}