using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AracKiralama.WebApi.Controllers
{
    [Route("api/Cars")]
    public class CarsController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new CarBusiness())
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
                using (var c = new CarBusiness())
                {
                    var temp = c.GetAll().Where(s=>s.Id==id).FirstOrDefault();
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
        public IHttpActionResult Post([FromBody]Car car)
        {
            try
            {
                using (var c = new CarBusiness())
                {
                    if(c.Insert(car))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]Car car)
        {
            try
            {
                using (var c = new CarBusiness())
                {
                    if (c.Update(car))
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