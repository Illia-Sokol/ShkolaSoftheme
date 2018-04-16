using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Regions;

namespace DesignPatterns.Common
{
    public class WindowServiceManager
    {
        private static WindowServiceManager instance;
        private WindowServiceManager()
        {
 
        }
        public static WindowServiceManager GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WindowServiceManager();
                }
                return instance;
            }
        }

        //private void ShowView(Type viewType, string regionName, Func<object> getDelegate)
        //{
        //    IRegionManager regionManager = new RegionManager();
        //    var _view = ServiceLocator.Current.GetInstance<viewType>();

        //    var region = regionManager.Regions[regionName];
        //    region.Add(_view);
        //    if (region != null)
        //    {
        //        region.Activate(_view);
        //    }     
        //}
    }
}
