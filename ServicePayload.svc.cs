using Microsoft.ApplicationServer.Http.Activation;
using Microsoft.ApplicationServer.Http.Description;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace ProjectForIgentics
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePayload" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePayload.svc or ServicePayload.svc.cs at the Solution Explorer and start debugging.
    public class ServicePayload : IServicePayload
    {
        public bool create(Payload payload)
        {
            using (PayPeopleEntities ppe = new PayPeopleEntities())
            {
                try
                {
                    PayloadEntity pe = new PayloadEntity();
                    pe.FirstName = payload.FirstName;
                    pe.LastName = payload.LastName;
                    pe.Age = payload.Age;
                    pe.Gender = payload.Gender;
                    pe.Email = payload.Email;
                    ppe.PayloadEntities.Add(pe);
                    ppe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }                             
            };
        }

        public List<Payload> findAll()
        {
            using (PayPeopleEntities ppe = new PayPeopleEntities())
            {            
                return ppe.PayloadEntities.Select(pe => new Payload
                {
                    FirstName = pe.FirstName,
                    LastName = pe.LastName,
                    Age = pe.Age,
                    Gender = pe.Gender,
                    Email = pe.Email,
                    Registered = pe.Registered
                }).ToList();
            }
          }
        }
    }

