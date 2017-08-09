using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

using System.Data.Entity;
using sime.Models;
using Newtonsoft.Json; 


namespace sime.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EquipoController : ApiController
    {
        
        private sime_dbEntities1 myEntity = new sime_dbEntities1();
        
        // GET api/equipo
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<equipo> Get()
        {
            return myEntity.equipoes.AsEnumerable();
        }

        // GET api/equipo/5
        [HttpGet]
        [ActionName("SelectByID")]
        public equipo Get(int id)
        {
            equipo fnd = myEntity.equipoes.Find(id);
            return fnd;
        }

        

        // POST api/equipo
        [HttpPost]
        [ActionName("Add")]
        public void Post(equipo equipo)
        {
            
            if (ModelState.IsValid)
            {
                myEntity.equipoes.Add(equipo);
                myEntity.SaveChanges();
            }
        }  

        // PUT api/equipo
        [HttpPut]
        [ActionName("Modify")]
        public void Put(equipo equipo)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(equipo).State = EntityState.Modified;
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

        // DELETE api/equipo/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            equipo dlt = myEntity.equipoes.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.equipoes.Remove(dlt);
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
