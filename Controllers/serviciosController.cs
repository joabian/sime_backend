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
    public class serviciosController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/servicios
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<servicio> Get()
        {
            return myEntity.servicios.AsEnumerable();
        }

        // GET api/servicios/5
        [HttpGet]
        [ActionName("SelectByID")]
        public servicio Get(int id)
        {
            servicio svc = myEntity.servicios.Find(id);
            return svc;

        }

        // POST api/servicios
        [HttpPost]
        [ActionName("Add")]
        public void Post(servicio svc)
        {
            if (ModelState.IsValid)
            {
                myEntity.servicios.Add(svc);
                myEntity.SaveChanges();
            }
        }

        // PUT api/servicios/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(servicio svc)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(svc).State = EntityState.Modified;
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

        // DELETE api/servicios/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            servicio dlt = myEntity.servicios.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.servicios.Remove(dlt);
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
