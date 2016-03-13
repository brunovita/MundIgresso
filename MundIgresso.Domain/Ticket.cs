using System;

namespace MundIgresso.Domain
{
    public class Ticket
    {
        public Ticket()
        {
            this.AcquireDate = DateTime.Now;
        }

        public int TicketID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime AcquireDate { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return this.Title;
        }

    }
}
