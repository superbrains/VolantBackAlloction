using BAServices.ViewModels.Operators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAServices.Interfaces
{
   public interface IOperatorService
    {
        Task<int> Create(OperatorVM operatorVM);
        List<OperatorVM> GetAll();
        OperatorVM GetTenant(int ID);
        int Delete(int ID);
    }
}
