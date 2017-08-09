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
    public class logsController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();
        
        // GET api/logs
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<log> Get()
        {
            return myEntity.logs.AsEnumerable();
        }

        // GET api/logs/5
        [HttpGet]
        [ActionName("SelectByID")]
        public log Get(int id)
        {
            log lg = myEntity.logs.Find(id);
            return lg;

        }

        // POST api/logs
        [HttpPost]
        [ActionName("Add")]
        public void Post(log lg)
        {
            if (ModelState.IsValid)
            {
                myEntity.logs.Add(lg);
                myEntity.SaveChanges();
            }
        }

        // PUT api/logs/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(log lg)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(lg).State = EntityState.Modified;
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

        // DELETE api/logs/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            log dlt = myEntity.logs.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.logs.Remove(dlt);
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
