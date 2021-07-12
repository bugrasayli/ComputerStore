using Microsoft.EntityFrameworkCore;

namespace Computer.Infrastucture
{
    public class ComputerContext : DbContext
    {
        public DbSet<Computer.Core.Entities.Computer> Computers{ get; set; }
        public DbSet<Computer.Core.Entities.Ram> Rams{ get; set; }
        public DbSet<Computer.Core.Entities.GraphicCard> GraphicCard{ get; set; }
        public ComputerContext(DbContextOptions<ComputerContext> opt) : base(opt) 
        {

        }
        
    }

}
