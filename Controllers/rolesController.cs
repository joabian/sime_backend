using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using sime.Models; 

namespace sime.Controllers
{
    public class rolesController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/roles
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<role> Get()
        {
            return myEntity.roles.AsEnumerable();
        }

        // GET api/roles/5
        [HttpGet]
        [ActionName("SelectByID")]
        public role Get(int id)
        {
            role rl = myEntity.roles.Find(id);
            return rl;

        }

        // POST api/roles
        [HttpPost]
        [ActionName("Add")]
        public void Post(role rl)
        {
            if (ModelState.IsValid)
            {
                myEntity.roles.Add(rl);
                myEntity.SaveChanges();
            }
        }

        // PUT api/roles/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(role rl)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(rl).State = EntityState.Modified;
                try
                {
                    myEntity.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // DELETE api/roles/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            role dlt = myEntity.roles.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.roles.Remove(dlt);
                    myEntity.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}
