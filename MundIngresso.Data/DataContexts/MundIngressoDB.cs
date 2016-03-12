using MundIgresso.Domain;
using MundIngresso.Data.Mappings;
using System.Data.Entity;

namespace MundIngresso.Data.DataContexts
{
    public class MundIngressoDB : DbContext
    {
        public MundIngressoDB() : base ("MundIngressoConnectionString")
        {
            Database.SetInitializer<MundIngressoDB>(new MundIngressoInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
