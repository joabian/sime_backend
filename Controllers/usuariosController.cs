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
    public class usuariosController : ApiController
    {

        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/usuarios
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<usuario> Get()
        {
            return myEntity.usuarios.AsEnumerable();
        }

        // GET api/usuarios/5
        [HttpGet]
        [ActionName("SelectByID")]
        public usuario Get(int id)
        {
            usuario usr = myEntity.usuarios.Find(id);
            return usr;

        }

        // POST api/usuarios
        [HttpPost]
        [ActionName("Add")]
        public void Post(usuario usr)
        {
            if (ModelState.IsValid)
            {
                myEntity.usuarios.Add(usr);
                myEntity.SaveChanges();
            }
        }

        // PUT api/usuarios/5
        [HttpPut]
        [ActionName("Modify")]
        public void Put(usuario usr)
        {
            if (ModelState.IsValid)
            {
                myEntity.Entry(usr).State = EntityState.Modified;
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

        // DELETE api/usuarios/5
        [HttpDelete]
        [ActionName("Remove")]
        public void Delete(int id)
        {
            usuario dlt = myEntity.usuarios.Find(id);
            if (dlt != null)
            {
                try
                {
                    myEntity.usuarios.Remove(dlt);
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
