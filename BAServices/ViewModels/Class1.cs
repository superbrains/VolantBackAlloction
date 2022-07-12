using System;
using System.Collections.Generic;
using System.Text;

namespace BAServices.ViewModels
{

    public class Rootobject
    {
        public string _class { get; set; }
        public Nodedataarray[] nodeDataArray { get; set; }
        public Linkdataarray[] linkDataArray { get; set; }
    }

    public class Nodedataarray
    {
        public string key { get; set; }
        public string category { get; set; }
        public string pos { get; set; }
        public string text { get; set; }
        public int angle { get; set; }
    }

    public class Linkdataarray
    {
        public string from { get; set; }
        public string to { get; set; }
        public float[] points { get; set; }
    }

}
