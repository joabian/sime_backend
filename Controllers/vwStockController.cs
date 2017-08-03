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
    public class vwStockController : ApiController
    {
        private sime_dbEntities1 myEntity = new sime_dbEntities1();

        // GET api/vwstock
        [HttpGet]
        [ActionName("SelectAll")]
        public IEnumerable<vw_stock> Get()
        {
            return myEntity.vw_stock.AsEnumerable();
        }
        
    }
}
