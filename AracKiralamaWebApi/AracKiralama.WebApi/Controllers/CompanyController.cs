using AracKiralama.Business.Concretes;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AracKiralama.WebApi.Controllers
{
    [Route("api/Company")]
    public class CompanyController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                using (var c = new CompanyBusiness())
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
                using (var c = new CompanyBusiness())
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
        public IHttpActionResult Post([FromBody]Company company)
        {
            return BadRequest();
            //try
            //{
            //    using (var c = new CompanyBusiness())
            //    {
            //        if (c.Insert(company))
            //            return Ok();
            //        return NotFound();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest($"{ex}");
            //}
        }
        public IHttpActionResult Put([FromBody]Company company)
        {
            return BadRequest();
            //try
            //{
            //    using (var c = new CompanyBusiness())
            //    {
            //        if (c.Update(company))
            //            return Ok();
            //        return NotFound();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest($"{ex}");
            //}
        }
    }
}
