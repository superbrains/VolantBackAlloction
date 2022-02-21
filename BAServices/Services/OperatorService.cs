using AutoMapper;
using BAServices.Interfaces;
using BAServices.Models;
using BAServices.ViewModels.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolantBackAlloction.Models;

namespace BAServices.Services
{
    public class OperatorService: IOperatorService
    {
        private readonly DBContext _context;
        private readonly IMapper _mapper;
        public OperatorService(DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<int> Create(OperatorVM operatorVM)
        {
            try
            {
                operatorVM.Logo = "";
                operatorVM.Status = "Active";
                var opr = _mapper.Map<Operators>(operatorVM);
                if (operatorVM.ID > 0)
                {
                    _context.Operators.Update(opr);
                }
                else
                {
                    _context.Operators.Add(opr);
                }


                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<OperatorVM> GetAll()
        {
            var opr = _context.Operators.ToList();

            return _mapper.Map<List<OperatorVM>>(opr);

        }
        public OperatorVM GetOperator(int ID)
        {
            var temp = _context.Operators.FirstOrDefault(x => x.ID == ID);
            return _mapper.Map<OperatorVM>(temp);
        }

        public int Delete(int ID)
        {
            var tenant = _context.Operators.FirstOrDefault(x => x.ID == ID);
            _context.Operators.Remove(tenant);

            _context.SaveChangesAsync();
            return 1;
        }
    }
}
