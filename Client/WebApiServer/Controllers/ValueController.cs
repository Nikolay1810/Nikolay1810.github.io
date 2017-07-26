using Ninject;
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
using WebApiServer.Infrastructure.Context;
using WebApiServer.Infrastructure.DIModule;
using WebApiServer.Infrastructure.Repository;
using WebApiServer.Models.Regisrtation;
using WebApiServer.Models.User;

namespace WebApiServer.Controllers
{
    public class ValueController : ApiController
    {
        public IRepository<Users> repository;

        private ValueController()
        {
            repository = new CabinetRepository<Users>(new CabinetContext());
        }

        // GET: api/Value
        public IQueryable<Users> GetUsers()
        {
            return repository.Get();
        }

        // GET: api/Value/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult GetUsers(int id)
        {
            Users users = repository.FindById(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        // PUT: api/Value/5
        [ResponseType(typeof(void))]
        [ActionName("update")]
        public IHttpActionResult PutUsers(int id, Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users.Id)
            {
                return BadRequest();
            }

            try
            {
                var IsExistedUser = repository.UpdateEntity(users);
                if (IsExistedUser == false)
                {
                    return NotFound();
                }
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

        // POST: api/Value
        [ResponseType(typeof(Users))]
        public IHttpActionResult PostUsers(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser =  repository.AddEntity(users);

            return Ok(newUser); 
        }

        // DELETE: api/Value/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult DeleteUsers(int id)
        {
            Users users = repository.FindById(id);
            if (users == null)
            {
                return NotFound();
            }

            repository.DeleteEntity(users);

            return Ok(users);
        }
        [ResponseType(typeof(Authorize))]
        [ActionName("login")]
        public IHttpActionResult Login(int id, Authorize authorizeData)
        {
            Func<Users, bool> predicate = (u => u.Logins == authorizeData.login && u.Passwords == authorizeData.password);
            var user = repository.Get(predicate);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(int id)
        {
            var users = repository.Get(e => e.Id == id);
            return users != null? true : false;
        }
    }
}