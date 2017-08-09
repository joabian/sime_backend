﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using sime.Models; 

namespace sime.Controllers
{
    public class vwAreasController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/vwareas
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<vw_areas> Get()
        {
            return myEntity.vw_areas.AsEnumerable();
        }

        // GET api/vwareas/5
        [HttpGet]
        [ActionName("SelectByID")]
        public vw_areas Get(int id)
        {
            vw_areas vwar = myEntity.vw_areas.Find(id);
            return vwar;

        }

        // POST api/vwareas
        [HttpPost]
        [ActionName("Add")]
        public void Post(vw_areas vwar)
        {
            if (ModelState.IsValid)
            {
                myEntity.vw_areas.Add(vwar);
                myEntity.SaveChanges();
            }
        }

        // PUT api/vwareas/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(vw_areas vwar)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(vwar).State = EntityState.Modified;
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

        // DELETE api/vwareas/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            vw_areas dlt = myEntity.vw_areas.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.vw_areas.Remove(dlt);
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
