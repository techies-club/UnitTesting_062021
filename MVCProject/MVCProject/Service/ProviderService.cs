using MVCProject.Models;
using MVCProject.Repository;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Service
{
    public class ProviderService
    {
        private readonly ProviderRepository context = new ProviderRepository();
        public List<Provider> GetProvidersForIndex() => context.Providers.ToList();
        public Provider GetProvidersById(int id) => context.Providers.Where(i=>i.ProviderID== id).FirstOrDefault();
    }
}