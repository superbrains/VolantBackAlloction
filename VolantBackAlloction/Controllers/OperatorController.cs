using BAServices.Interfaces;
using BAServices.ViewModels.Operators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolantBackAlloction.Controllers
{
    public class OperatorController : Controller
    {
        private readonly IOperatorService _operatorService;

        public OperatorController(IOperatorService operatorService)
        {
            _operatorService = operatorService;
        }
        public IActionResult Index()
        {
            OperatorData opr = new OperatorData();
            //Return Info 
            opr.OperatorModel = new OperatorVM();
            opr.OperatorList = _operatorService.GetAll();
            return View(opr);
        }

        public JsonResult Save(OperatorVM model)
        {
            try
            {
                _operatorService.Create(model);
                if (model.ID > 0)
                {
                    return Json("Operator Information has been updated successfully");
                }
                else
                {
                    return Json("A New Operator has been created successfully");
                }

            }
            catch (System.Exception ex)
            {

                return Json("An Error Occured " + ex.Message);
            }


        }

        public JsonResult Delete(int ID)
        {
            try
            {
                _operatorService.Delete(ID);

                return Json("Operator Deleted Successfully");

            }
            catch (System.Exception ex)
            {
                return Json("An Error Occured " + ex.Message);
            }

        }
    }
}
