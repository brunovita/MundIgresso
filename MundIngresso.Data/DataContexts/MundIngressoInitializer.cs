using MundIgresso.Domain;
using System.Data.Entity;

namespace MundIngresso.Data.DataContexts
{
    public class MundIngressoInitializer : DropCreateDatabaseAlways<MundIngressoContext>
    {
        protected override void Seed(MundIngressoContext context)
        {
            context.Tickets.Add(new Ticket { TicketID = 1, Title = "Deadpool", Price = 20, IsActive = true });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
