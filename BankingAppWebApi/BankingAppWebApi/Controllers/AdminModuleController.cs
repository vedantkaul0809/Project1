﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankingAppWebApi.Models;
using System.Web.Http.Cors;
//update admin in b2
//update admin
//hi this is a change
//second change in admin
//third change in branch
//change in master and branch 
namespace BankingAppWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminModuleController : ApiController
    {
        [Route("api/AdminModule/PostAdminLogin")]
        public HttpResponseMessage PostAdminLogin([FromBody] AdminModule admin)
        {
            try
            {
                using (BankingAppEntities db = new BankingAppEntities())
                {
                    //UserLogin_Result res = db.UserLogin(customer.CustomerId, customer.LoginPassword).FirstOrDefault();
                    var data = db.AdminModules.Find(admin.AdminId);
                    if (data.AdminPassword == admin.AdminPassword)
                        return Request.CreateResponse(HttpStatusCode.OK, "Logged in as Admin");
                    else
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Credentials");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }
        }

    }
}
