using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyModels;

namespace MyWebApi.Controllers
{
    public class WorksController : ApiController
    {
        // GET: api/Works
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Works/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Works
        public IHttpActionResult Post([FromBody]WorksData value)
        {
            if (ModelState.IsValid)
            {
                Debug.Assert(value.Album != null);
                Debug.Assert(value.Topic != null);
                Debug.Assert(value.WorksMediaList != null);
                Debug.Assert(value.WorksMediaList.Count > 0);
                Debug.Assert(value.WorksMediaList[0] !=null);

                return CreatedAtRoute("DefaultApi", new { id = value.WorksId }, value);
            }
            return BadRequest();
        }

        // PUT: api/Works/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Works/5
        public void Delete(int id)
        {
        }
    }
}
