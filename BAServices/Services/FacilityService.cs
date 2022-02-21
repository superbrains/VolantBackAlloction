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
        private readonly IOperatorService _operatorService;
        public FacilityService(DBContext context, IMapper mapper, IOperatorService operatorService)
        {
            _context = context;
            _mapper = mapper;
            _operatorService = operatorService;

        }
        public int Create(FacilityVM facilityVM)
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


                return  _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<FacilityVM> GetAll()
        {
            var facilities = _context.Facilities.ToList();
           

          var mappedFacility = _mapper.Map<List<FacilityVM>>(facilities);

            foreach (var item in mappedFacility)
            {
                item.Operator = _operatorService.GetOperator(item.OperatorID)?.BusinessName;   
            }

            return mappedFacility;
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
