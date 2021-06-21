using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCProject.Repository
{
    public class ProviderRepository
    {  
        //Entities        
        public IEnumerable<Provider> Providers
        {
            get
            {
                return new List<Provider>
                {
                    { new Provider { ProviderID = 100, ProviderName = "AK", ProviderTin = "11111" } } ,
                    { new Provider { ProviderID = 200, ProviderName = "KS", ProviderTin = "22222" } }
                };
            }

        }
    }
}