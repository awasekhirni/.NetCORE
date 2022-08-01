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
    public class StateApiController : ApiController
    {
        private DealerTrackContext db = new DealerTrackContext();

        // GET: api/StateApi
        public IQueryable<State> GetStates()
        {
            return db.States;
        }

        // GET: api/StateApi/5
        [ResponseType(typeof(State))]
        public IHttpActionResult GetState(int id)
        {
            State state = db.States.Find(id);
            if (state == null)
            {
                return NotFound();
            }

            return Ok(state);
        }

        // PUT: api/StateApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutState(int id, State state)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != state.stateId)
            {
                return BadRequest();
            }

            db.Entry(state).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateExists(id))
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

        // POST: api/StateApi
        [ResponseType(typeof(State))]
        public IHttpActionResult PostState(State state)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.States.Add(state);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = state.stateId }, state);
        }

        // DELETE: api/StateApi/5
        [ResponseType(typeof(State))]
        public IHttpActionResult DeleteState(int id)
        {
            State state = db.States.Find(id);
            if (state == null)
            {
                return NotFound();
            }

            db.States.Remove(state);
            db.SaveChanges();

            return Ok(state);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StateExists(int id)
        {
            return db.States.Count(e => e.stateId == id) > 0;
        }
    }
}