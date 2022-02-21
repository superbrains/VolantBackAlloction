using AutoMapper;
using BAServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VolantBackAlloction.Models;
using VolantBackAlloction.ViewModels.Tenant;

namespace BAServices.Services
{
    public class TenantService : ITenantService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        public TenantService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<int> Create(TenantVM TenantVM)
        {
            try
            {
                TenantVM.Logo = "";
                TenantVM.Status = "Active";
                var tenant = _mapper.Map<Tenants>(TenantVM);
               
                _context.Tenants.Add(tenant);

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public Task<List<TenantVM>> GetAll()
        {
           
            throw new NotImplementedException();
        }

        public Task<TenantVM> GetTenant(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
