using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ISCSystem.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("api/Users")]
        // GET: api/Users
        [HttpGet]
        public IQueryable<Users> GetlistUsers()
        {
            return db.listUsers;
        }

        // GET: api/Users/5
        [ResponseType(typeof(Users))]
        public async Task<IHttpActionResult> GetUsers(int id)
        {
            Users users = await db.listUsers.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUsers(int id, Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users.UserID)
            {
                return BadRequest();
            }

            db.Entry(users).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
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

        // POST: api/Users
        [ResponseType(typeof(Users))]
        [HttpPost]
        [Route("api/Users")]
        public async Task<IHttpActionResult> PostUsers([FromBody] Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.listUsers.Add(users);
            await db.SaveChangesAsync();

            //return CreatedAtRoute("DefaultApi", new { id = users.UserID }, users);
            return RedirectToRoute("Default", new { controller = "UsersView", action = "Index" });
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(Users))]
        [HttpDelete]
        [Route("api/Users/{id}")]
        public async Task<IHttpActionResult> DeleteUsers(int id)
        {
            Users users = await db.listUsers.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            db.listUsers.Remove(users);
            await db.SaveChangesAsync();

            //return Ok(users);
            return RedirectToRoute("Default", new { controller = "UsersView", action = "Index" });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(int id)
        {
            return db.listUsers.Count(e => e.UserID == id) > 0;
        }
    }
}