using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AracKiralama.WebApi.Controllers
{
    [Route("api/Rentacar")]
    public class RentACarController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new RentedCarBusiness())
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
                using (var c = new RentedCarBusiness())
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
        public IHttpActionResult Post([FromBody]RentedCar car)
        {
            try
            {
                using (var c = new RentedCarBusiness())
                {
                    if (c.Insert(car))
                        return Ok();
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex}");
            }
        }
        public IHttpActionResult Put([FromBody]RentedCar car)
        {
            try
            {
                using (var c = new RentedCarBusiness())
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
