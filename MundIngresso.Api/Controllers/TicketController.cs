using MundIgresso.Domain;
using MundIngresso.Data.DataContexts;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MundIngresso.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class TicketController : ApiController
    {
        private MundIngressoContext db = new MundIngressoContext();
        [Route("Tickets")]
        public HttpResponseMessage GetTickets()
        {
            var result = db.Tickets.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("ticket")]
        public HttpResponseMessage PostTicket(Ticket ticket)
        {
            if (ticket == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                db.Tickets.Add(ticket);
                db.SaveChanges();
                var result = ticket;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (System.Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao Adicionar Ticket");
            }
        }

        [HttpPatch]
        [Route("ticket")]
        public HttpResponseMessage PacthTicket(Ticket ticket)
        {
            if (ticket == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                db.Entry<Ticket>(ticket).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                var result = ticket;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (System.Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao alterar Ticket");
            }
        }

        [HttpPut]
        [Route("ticket")]
        public HttpResponseMessage PutTicket(Ticket ticket)
        {
            if (ticket == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                db.Entry<Ticket>(ticket).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                var result = ticket;
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (System.Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao alterar Ticket");
            }
        }

        [HttpDelete]
        [Route("ticket")]
        public HttpResponseMessage DeleteTicket(int ticketid)
        {
            if (ticketid <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                db.Tickets.Remove(db.Tickets.Find(ticketid));
                db.SaveChanges();
                var result = ticketid;
                return Request.CreateResponse(HttpStatusCode.OK, "Ticket Excluído.");
            }
            catch (System.Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir");
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}