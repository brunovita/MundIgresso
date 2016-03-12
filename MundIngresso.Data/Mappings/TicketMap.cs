using MundIgresso.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundIngresso.Data.Mappings
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            ToTable("Ticket");
            HasKey(x => x.TicketID);
            Property(x => x.Title).HasMaxLength(120).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category);
        }
    }
}
