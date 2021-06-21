using MVCProject.Interface;
using MVCProject.Models;
using MVCProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Service
{
    public class FacilityService : IFacilityService
    {
        private IFacilityRepository _facilityRepository;
       
        public FacilityService(IFacilityRepository facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }
        public List<Facility> GetFacilitiesForZip(string zip) => _facilityRepository.GetFacilities().Where(z => z.Address.Contains(zip)).ToList();

        public List<Facility> GetFacilities() => _facilityRepository.GetFacilities().ToList();
    }
}