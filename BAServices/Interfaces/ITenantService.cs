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
        Task<List<TenantVM>> GetAll();
        Task<TenantVM> GetTenant(int ID);
    }
}
