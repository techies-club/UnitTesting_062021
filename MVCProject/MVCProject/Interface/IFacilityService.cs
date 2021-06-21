using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Interface
{
   public interface IFacilityService
    {
        List<Facility> GetFacilitiesForZip(string zip);
        List<Facility> GetFacilities();
    }
}
