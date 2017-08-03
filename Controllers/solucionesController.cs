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
    public class solucionesController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/soluciones
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<solucione> Get()
        {
            return myEntity.soluciones.AsEnumerable();
        }

        // GET api/soluciones/5
        [HttpGet]
        [ActionName("SelectByID")]
        public solucione Get(int id)
        {
            solucione sol = myEntity.soluciones.Find(id);
            return sol;

        }

        // POST api/soluciones
        [HttpPost]
        [ActionName("Add")]
        public void Post(solucione sol)
        {
            if (ModelState.IsValid)
            {
                myEntity.soluciones.Add(sol);
                myEntity.SaveChanges();
            }
        }

        // PUT api/soluciones/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(solucione sol)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(sol).State = EntityState.Modified;
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

        // DELETE api/soluciones/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            solucione dlt = myEntity.soluciones.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.soluciones.Remove(dlt);
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
