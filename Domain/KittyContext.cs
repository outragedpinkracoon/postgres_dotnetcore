using Microsoft.EntityFrameworkCore;
namespace FirstApp.Domain {
    public class KittyContext : DbContext  
    {
        public KittyContext(DbContextOptions<KittyContext> options)
            : base(options){}
        
        public DbSet<Kitty> Kitties { get; set; }
    }
}