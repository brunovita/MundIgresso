using MundIgresso.Domain;
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
    }
}
