using BAServices.ViewModels.Well;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAServices.Interfaces
{
   public interface iWell
    {
        int Create(WellVM wellVM);
        List<WellVM> GetAll();
        WellVM GetWell(int ID);
        int Delete(int ID);
    }
}
