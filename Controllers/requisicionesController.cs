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
    public class requisicionesController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/requisiciones
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<requisicione> Get()
        {
            return myEntity.requisiciones.AsEnumerable();
        }

        // GET api/requisiciones/5
        [HttpGet]
        [ActionName("SelectByID")]
        public requisicione Get(int id)
        {
            requisicione req = myEntity.requisiciones.Find(id);
            return req;

        }

        // POST api/requisiciones
        [HttpPost]
        [ActionName("Add")]
        public void Post(requisicione req)
        {
            if (ModelState.IsValid)
            {
                myEntity.requisiciones.Add(req);
                myEntity.SaveChanges();
            }
        }

        // PUT api/requisiciones/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(requisicione req)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(req).State = EntityState.Modified;
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

        // DELETE api/requisiciones/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            requisicione dlt = myEntity.requisiciones.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.requisiciones.Remove(dlt);
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
