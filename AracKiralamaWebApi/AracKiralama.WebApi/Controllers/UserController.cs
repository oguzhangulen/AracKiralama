using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AracKiralama.WebApi.Controllers
{
    [Route("api/User")]
    public class UserController : ApiController
    {
        public IHttpActionResult Get()
        {
            return BadRequest();
            //try
            //{
            //    using (var c = new UserBusiness())
            //    {
            //        var templist = c.GetAll().ToList();
            //        if (templist == null)
            //            return NotFound();
            //        return Ok(templist);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest($"{ex}");
            //}
        }
    }
}
