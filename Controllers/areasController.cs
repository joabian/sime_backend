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
    public class areasController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/areas
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<area> Get()
        {
            return myEntity.areas.AsEnumerable();
        }

        // GET api/areas/5
        [HttpGet]
        [ActionName("SelectByID")]
        public area Get(int id)
        {
            area ar = myEntity.areas.Find(id);
            return ar;

        }

        // POST api/areas
        [HttpPost]
        [ActionName("Add")]
        public void Post(area ar)
        {
            if (ModelState.IsValid)
            {
                myEntity.areas.Add(ar);
                myEntity.SaveChanges();
            }
        }

        // PUT api/areas/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(area ar)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(ar).State = EntityState.Modified;
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

        // DELETE api/areas/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            area dlt = myEntity.areas.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.areas.Remove(dlt);
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
