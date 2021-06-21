using MVCProject.Interface;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Repository
{
    public class FacilityRepository : IFacilityRepository
    {
        public IEnumerable<Facility> GetFacilities()
        {
            return new List<Facility>
                {
                     { new Facility { FacilityID = 101, FacilityName = "Concentra", Address = "100 main st, VA-20878" } },
                     { new Facility { FacilityID = 101, FacilityName = "First Ad", Address = "555 Jeneva Ln, VA-20878" } },
                     { new Facility { FacilityID = 101, FacilityName = "Child Care", Address = "Saint avenue, MD-70008" } }
                };

        }
    }
}