using Owindows.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Owindows.controllers
{
    public class InsuranceController : ApiController
    {

        public IHttpActionResult Get()
        {

            IList <InsuranceModel> insurances= new List<InsuranceModel>();

            insurances.Add(new InsuranceModel() { policyId = 123123123, policyName = "LIC jeevan Suraksha", policyType = "life", premiumAmount = 231232.22, insuredAmount = 500000000, isActive=true});

            insurances.Add(new InsuranceModel() { policyId = 123123123, policyName = "HDFC Home", policyType = "Home", premiumAmount = 4435232.22, insuredAmount = 8000000000, isActive = true });
            insurances.Add(new InsuranceModel() { policyId = 123123123, policyName = "Bajaj vehicle", policyType = "MotorVehicle", premiumAmount = 232.22, insuredAmount = 60000, isActive = true });
            insurances.Add(new InsuranceModel() { policyId = 123123123, policyName = "LIC jeevan Abhishek", policyType = "life", premiumAmount = 231232.22, insuredAmount = 900000000, isActive = true });
            insurances.Add(new InsuranceModel() { policyId = 123123123, policyName = "Met Life  ", policyType = "Health", premiumAmount = 231232.22, insuredAmount = 1500000000, isActive = true });
            // status code OK => 200
            // Success code 
            // data 
            return Ok<IList<InsuranceModel>>(insurances);

        }

        
    }
}
