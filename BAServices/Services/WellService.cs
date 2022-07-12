using AutoMapper;
using BAServices.Interfaces;
using BAServices.ViewModels.Well;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VolantBackAlloction.Models;

namespace BAServices.Services
{
    public class WellService : iWell
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        private readonly IOperatorService _operatorService;
        public WellService(DBContext context, IMapper mapper, IOperatorService operatorService)
        {
            _context = context;
            _mapper = mapper;
            _operatorService = operatorService;
        }
        public int Create(WellVM wellVM)
        {
            try
            {
                var well = _mapper.Map<Well>(wellVM);
                if (well.ID > 0)
                {
                    _context.Well.Update(well);
                }
                else
                {
                    _context.Well.Add(well);
                }

                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Delete(int ID)
        {
            var well = _context.Well.FirstOrDefault(x => x.ID == ID);
            _context.Well.Remove(well);

            _context.SaveChangesAsync();
            return 1;
        }

        public List<WellVM> GetAll()
        {
            var wells = _context.Well.ToList();


            var mappedwell = _mapper.Map<List<WellVM>>(wells);

            //foreach (var item in mappedwell)
            //{
            //    item.Operator = _operatorService.GetOperator(item.OperatorID)?.BusinessName;
            //}

            return mappedwell;
        }

        public WellVM GetWell(int ID)
        {
            var temp = _context.Well.FirstOrDefault(x => x.ID == ID);
            return _mapper.Map<WellVM>(temp);
        }
    }
}
