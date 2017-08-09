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
    public class fotosController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/fotos
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<foto> Get()
        {
            return myEntity.fotos.AsEnumerable();
        }

        // GET api/fotos/5
        [HttpGet]
        [ActionName("SelectByID")]
        public foto Get(int id)
        {
            foto ft = myEntity.fotos.Find(id);
            return ft;

        }

        // POST api/fotos
        [HttpPost]
        [ActionName("Add")]
        public void Post(foto ft)
        {
            if (ModelState.IsValid)
            {
                myEntity.fotos.Add(ft);
                myEntity.SaveChanges();
            }
        }

        // PUT api/fotos/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(foto ft)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(ft).State = EntityState.Modified;
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

        // DELETE api/fotos/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            foto dlt = myEntity.fotos.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.fotos.Remove(dlt);
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
