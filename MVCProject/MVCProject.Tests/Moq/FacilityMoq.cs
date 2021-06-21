using MVCProject.Interface;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Tests.Moq
{
    //NOT USED
    public class FacilityRepositoryMoq : IFacilityRepository
    {

        List<Facility>  facilities;

        public  FacilityRepositoryMoq()
        {
            facilities = new List<Facility>();
            facilities.Add(new Facility { FacilityID = 111, FacilityName = "dummy facility1", Address = "some fake address-20878" });
            facilities.Add(new Facility { FacilityID = 222, FacilityName = "dummy facility2", Address = "some fake address2-20878" });
            facilities.Add(new Facility { FacilityID = 333, FacilityName = "dummy facility3", Address = "some fake address3-70008" });
            
        }

        public IEnumerable<Facility> GetFacilities()
        {
           return facilities;
        }
    }
}
