using BAServices.Interfaces;
using BAServices.Models;
using BAServices.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VolantBackAlloction.Controllers
{
    public class AssetController : Controller
    {
        private readonly IAssets _assetService;

        public AssetController(IAssets assetService)
        {
            _assetService = assetService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Load(int tenantId)
        {
            var result = _assetService.GetAssets(1);
            return Json(result);
        }

            public JsonResult Save(string assetString)
        {
            // AssetDiagramModel asset = JsonConvert.DeserializeObject<AssetDiagramModel>(assetString);

            AssetDiagramModel assetDiagram = JsonConvert.DeserializeObject<AssetDiagramModel>(assetString);

            List<Nodes> nodes = new List<Nodes>();
            List<Links> links = new List<Links>();

            foreach (var item in assetDiagram.linkDataArray)
            {
                links.Add(new Links { from = item.from, to = item.to, TenantID = 1 });
            }

            foreach (var item in assetDiagram.nodeDataArray)
            {
                nodes.Add(new Nodes { TenantID = 1, category=item.category, key=item.key, location=item.location, size=item.size, text=item.text });
            }


            try
            {
                //Check Rules before Creating Assets
                object response = null;
                var validationMessages = _assetService.CheckRules(nodes, links);
                if (validationMessages.Count > 0)
                {
                    response = validationMessages;
                }
                else
                {
                    var result = _assetService.CreateAsset(nodes, links);

                    response = "success";
                }                              

                return Json(response);
            }
            catch (System.Exception ex)
            {

                return Json("An Error Occured " + ex.Message);
            }


        }
    }
}
