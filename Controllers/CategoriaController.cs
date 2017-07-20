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
    
    public class CategoriaController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/categoria
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<categoria> Get()
        {
            return myEntity.categorias.AsEnumerable();
        }

        // GET api/categoria/5
        [HttpGet]
        [ActionName("SelectByID")]
        public categoria Get(int id)
        {
            categoria fnd = myEntity.categorias.Find(id);
            return fnd;
        }

        // POST api/categoria
        [HttpPost]
        [ActionName("Add")]
        public void Post(categoria categoria)
        {
            if (ModelState.IsValid)
            {
                myEntity.categorias.Add(categoria);
                myEntity.SaveChanges();
            }
        }

        // PUT api/categoria/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(categoria categoria)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(categoria).State = EntityState.Modified;
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

        // DELETE api/categoria/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            categoria dlt = myEntity.categorias.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.categorias.Remove(dlt);
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
