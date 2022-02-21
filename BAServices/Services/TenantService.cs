using AutoMapper;
using BAServices.Interfaces;
using BAServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                if (TenantVM.ID > 0)
                {
                    _context.Tenants.Update(tenant);
                }
                else
                {
                    _context.Tenants.Add(tenant);
                }
              

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        public  List<TenantVM> GetAll()
        {
            var tenant = _context.Tenants.ToList();

            return _mapper.Map<List<TenantVM>>(tenant);
         
        }
        public TenantVM GetTenant(int ID)
        {
           var temp =_context.Tenants.FirstOrDefault(x=>x.ID==ID);
           return _mapper.Map<TenantVM>(temp);
        }

        public int Delete(int ID)
        {
            var tenant = _context.Tenants.FirstOrDefault(x => x.ID == ID);
            _context.Tenants.Remove(tenant);

            _context.SaveChangesAsync();
            return 1;
        }
    }
}
