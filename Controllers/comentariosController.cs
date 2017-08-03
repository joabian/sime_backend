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
    public class comentariosController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/comentarios
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<comentario> Get()
        {
            return myEntity.comentarios.AsEnumerable();
        }

        // GET api/comentarios/5
        [HttpGet]
        [ActionName("SelectByID")]
        public comentario Get(int id)
        {
            comentario comm = myEntity.comentarios.Find(id);
            return comm;

        }

        // POST api/comentarios
        [HttpPost]
        [ActionName("Add")]
        public void Post(comentario comm)
        {
            if (ModelState.IsValid)
            {
                myEntity.comentarios.Add(comm);
                myEntity.SaveChanges();
            }
        }

        // PUT api/comentarios/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(comentario comm)
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
            comentario dlt = myEntity.comentarios.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.comentarios.Remove(dlt);
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
