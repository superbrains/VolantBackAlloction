using BAServices.Models;
using BAServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAServices.Interfaces
{
   public interface IAssets
    {
        int CreateAsset(List<Nodes> nodes, List<Links> links);
        AssetDiagramModel GetAssets(int tenantID);
        List<string> CheckRules(List<Nodes> nodes, List<Links> links);
    }
}
