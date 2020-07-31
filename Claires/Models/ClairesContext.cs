using Microsoft.EntityFrameworkCore;

namespace Claires.Models
{
  public class ClairesContext : DbContext
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public ClairesContext(DbContextOptions options) : base(options) { }
  }
}