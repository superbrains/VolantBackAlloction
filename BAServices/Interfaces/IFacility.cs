using BAServices.ViewModels.Facility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAServices.Interfaces
{
   public interface IFacility
    {
        Task<int> Create(FacilityVM facilityVM);
        List<FacilityVM> GetAll();
        FacilityVM GetFacility(int ID);
        int Delete(int ID);
    }
}
