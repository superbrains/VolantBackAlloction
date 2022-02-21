using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VolantBackAlloction.ViewModels.Tenant;

namespace BAServices.Interfaces
{
    public interface ITenantService
    {
        Task<int> Create(TenantVM TenantVM);
        List<TenantVM> GetAll();
        TenantVM GetTenant(int ID);
        int Delete(int ID);
    }
}
