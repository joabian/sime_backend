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
    public class SubcategoriaController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();
        /// <summary>
        /// Gets some very important data from the server.
        /// </summary>
        /// 
        // GET api/subcategoria3
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<subcategoria> Get()
        {
            return myEntity.subcategorias.AsEnumerable();
        }

        /// <summary>
        /// Looks up some data by ID.
        /// </summary>
        /// <param name="id">The ID of the data.</param>
        // GET api/subcategoria/5
        [HttpGet]
        [ActionName("SelectByID")]
        public subcategoria Get(int id)
        {
            subcategoria fnd = myEntity.subcategorias.Find(id);

            return fnd;
        }

        
        // GET api/subcategoria/GetByCategoryID/5
        [HttpGet]
        [ActionName("SelectByCategoryID")]
        public IEnumerable<subcategoria> GetByCategoryID(int id)
        {
            var query = from mysub in myEntity.subcategorias.AsEnumerable()
                        where mysub.categoriaID == id
                        select mysub;
            return query;
        }

        // POST api/subcategoria
        [HttpPost]
        [ActionName("Add")]
        public void Post(subcategoria subcategoria)
        {
            if (ModelState.IsValid)
            {
                myEntity.subcategorias.Add(subcategoria);
                myEntity.SaveChanges();
            }
        }

        // PUT api/subcategoria/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(subcategoria subcategoria)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(subcategoria).State = EntityState.Modified;
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

        // DELETE api/subcategoria/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            subcategoria dlt = myEntity.subcategorias.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.subcategorias.Remove(dlt);
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
