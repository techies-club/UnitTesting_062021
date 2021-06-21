using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Interface
{
    public interface IFacilityRepository
    {
        IEnumerable<Facility> GetFacilities();
    }
}