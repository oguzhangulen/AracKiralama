using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AracKiralama.WebApi.Controllers
{
    [Route("api/Request")]
    public class RequestController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new RequestBusiness())
                {
                    var templist = c.GetAll().ToList();
                    if (templist == null)
                        return NotFound();
                    return Ok(templist);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (var c = new RequestBusiness())
                {
                    var temp = c.GetAll().Where(s => s.Id == id).FirstOrDefault();
                    if (temp == null)
                        return NotFound();
                    return Ok(temp);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Post([FromBody]Request request)
        {
            try
            {
                using (var c = new RequestBusiness())
                {
                    if (c.Insert(request))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]Request request)
        {
            return BadRequest();
            //try
            //{
            //    using (var c = new RequestBusiness())
            //    {
            //        if (c.Update(request))
            //            return Ok();
            //        return NotFound();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest($"{ex}");
            //}
        }
        public IHttpActionResult Delete([FromBody]Request request)
        {
            try
            {
                using (var c = new RequestBusiness())
                {
                    if (c.Delete(request))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
    }
}
