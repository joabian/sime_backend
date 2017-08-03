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
    public class sucursalesController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();
        
        // GET api/sucursales
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<sucursale> Get()
        {
            return myEntity.sucursales.AsEnumerable();
        }

        // GET api/sucursales/5
        [HttpGet]
        [ActionName("SelectByID")]
        public sucursale Get(int id)
        {
            sucursale suc = myEntity.sucursales.Find(id);
            return suc;

        }

        // POST api/sucursales
        [HttpPost]
        [ActionName("Add")]
        public void Post(sucursale suc)
        {
            if (ModelState.IsValid)
            {
                myEntity.sucursales.Add(suc);
                myEntity.SaveChanges();
            }
        }

        // PUT api/sucursales/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(sucursale suc)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(suc).State = EntityState.Modified;
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

        // DELETE api/sucursales/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            sucursale dlt = myEntity.sucursales.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.sucursales.Remove(dlt);
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
