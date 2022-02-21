using AutoMapper;
using BAServices.Interfaces;
using BAServices.ViewModels.Facility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolantBackAlloction.Models;

namespace BAServices.Services
{
   public class FacilityService: IFacility
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        public FacilityService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<int> Create(FacilityVM facilityVM)
        {
            try
            {
                
                var facility = _mapper.Map<Facilities>(facilityVM);
                if (facilityVM.ID > 0)
                {
                    _context.Facilities.Update(facility);
                }
                else
                {
                    _context.Facilities.Add(facility);
                }


                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<FacilityVM> GetAll()
        {
            var facilities = _context.Facilities.ToList();

            return _mapper.Map<List<FacilityVM>>(facilities);

        }
        public FacilityVM GetFacility(int ID)
        {
            var temp = _context.Facilities.FirstOrDefault(x => x.ID == ID);
            return _mapper.Map<FacilityVM>(temp);
        }

        public int Delete(int ID)
        {
            var facilities = _context.Facilities.FirstOrDefault(x => x.ID == ID);
            _context.Facilities.Remove(facilities);

            _context.SaveChangesAsync();
            return 1;
        }
    }
}
