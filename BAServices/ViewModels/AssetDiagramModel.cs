using System;
using System.Collections.Generic;
using System.Text;

namespace BAServices.ViewModels
{
    public class LinkDataArray
    {
        public int from { get; set; }
        public int to { get; set; }
    }

    public class NodeDataArray
    {
        public string text { get; set; }
        public string category { get; set; }
        public string size { get; set; }
        public int key { get; set; }
        public string location { get; set; }
    }

    public class AssetDiagramModel
    {
        public string @class { get; set; }
        public List<NodeDataArray> nodeDataArray { get; set; }
        public List<LinkDataArray> linkDataArray { get; set; }
    }

    }

