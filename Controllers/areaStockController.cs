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
    public class areaStockController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/areastock
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<areaStock> Get()
        {
            return myEntity.areaStocks.AsEnumerable();
        }

        // GET api/comentarios/5
        [HttpGet]
        [ActionName("SelectByID")]
        public areaStock Get(int id)
        {
            areaStock comm = myEntity.areaStocks.Find(id);
            return comm;

        }

        // POST api/comentarios
        [HttpPost]
        [ActionName("Add")]
        public void Post(areaStock comm)
        {
            if (ModelState.IsValid)
            {
                myEntity.areaStocks.Add(comm);
                myEntity.SaveChanges();
            }
        }

        // PUT api/comentarios/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(areaStock comm)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(comm).State = EntityState.Modified;
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

        // DELETE api/comentarios/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            areaStock dlt = myEntity.areaStocks.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.areaStocks.Remove(dlt);
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
