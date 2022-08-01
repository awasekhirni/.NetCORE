using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DealersTrack.Context;
using DealersTrack.Models;

namespace DealersTrack.Controllers
{
    public class DealerApiController : ApiController
    {
        private DealerTrackContext db = new DealerTrackContext();

        // GET: api/DealerApi
        public IQueryable<Dealer> GetDealers()
        {
            return db.Dealers;
        }

        // GET: api/DealerApi/5
        [ResponseType(typeof(Dealer))]
        public IHttpActionResult GetDealer(int id)
        {
            Dealer dealer = db.Dealers.Find(id);
            if (dealer == null)
            {
                return NotFound();
            }

            return Ok(dealer);
        }

        // PUT: api/DealerApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDealer(int id, Dealer dealer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dealer.dealerId)
            {
                return BadRequest();
            }

            db.Entry(dealer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/DealerApi
        [ResponseType(typeof(Dealer))]
        public IHttpActionResult PostDealer(Dealer dealer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dealers.Add(dealer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dealer.dealerId }, dealer);
        }

        // DELETE: api/DealerApi/5
        [ResponseType(typeof(Dealer))]
        public IHttpActionResult DeleteDealer(int id)
        {
            Dealer dealer = db.Dealers.Find(id);
            if (dealer == null)
            {
                return NotFound();
            }

            db.Dealers.Remove(dealer);
            db.SaveChanges();

            return Ok(dealer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DealerExists(int id)
        {
            return db.Dealers.Count(e => e.dealerId == id) > 0;
        }
    }
}