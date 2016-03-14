using MundIgresso.Domain;
using System.Data.Entity;

namespace MundIngresso.Data.DataContexts
{
    public class MundIngressoContext : DbContext
    {
        public MundIngressoContext() : base ("MundIngressoConnectionString")
        {
            Database.SetInitializer<MundIngressoContext>(new MundIngressoInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
