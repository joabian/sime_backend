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
    public class actividadesController : ApiController
    {
        
        private sime_dbEntities1 myEntity = new sime_dbEntities1();
        
        // GET api/actividades
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<actividade> Get()
        {
            return myEntity.actividades.AsEnumerable();
        }

        // GET api/actividades/5
        [HttpGet]
        [ActionName("SelectByID")]
        public actividade Get(int id)
        {
            actividade act = myEntity.actividades.Find(id);
            return act;

        }

        // POST api/actividades
        [HttpPost]
        [ActionName("Add")]
        public void Post(actividade act)
        {
            if (ModelState.IsValid)
            {
                myEntity.actividades.Add(act);
                myEntity.SaveChanges();
            }
        }

        // PUT api/actividades/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(actividade act)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(act).State = EntityState.Modified;
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

        // DELETE api/actividades/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            actividade dlt = myEntity.actividades.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.actividades.Remove(dlt);
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
