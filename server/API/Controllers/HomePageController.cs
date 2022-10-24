using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/homepage")]

    public class HomePageController : ApiController
    {


        [Route("GetMember")]
        public IHttpActionResult GetMember()
        {
            var l = BL.MemberBL.GetMember();
            //var result = BL.MemberBL.GetMember();
            return Ok(l);

    //         Ok(JsonConvert.SerializeObject(
    //          result,
    //new JsonSerializerSettings
    //{
    //    ContractResolver = new CamelCasePropertyNamesContractResolver()
    //}));

        }
        [Route("AddMember"), HttpPost]
        public IHttpActionResult AddMember(MembersDTO member)
        {
            BL.MemberBL.AddMember(member);
            return Ok(true);
        }

        [Route("delete/{id}"), HttpDelete]
        public IHttpActionResult Delete(string id)
        {
           
            BL.MemberBL.Delete(id);
            return Ok(true);
        }
        [ActionName("saveChanges"), HttpPost]
        public IHttpActionResult SaveChanges(Members11 member)
        {
            BL.MemberBL.SaveChanges(member);
            return Ok(true);
        }
        [Route("getMemberById/{id}"), HttpGet]
        public IHttpActionResult GetMemberById([FromUri]string id)
        {
            var result = BL.MemberBL.GetMemberById(id);
            return Ok(result);
            
        }
    }
}
