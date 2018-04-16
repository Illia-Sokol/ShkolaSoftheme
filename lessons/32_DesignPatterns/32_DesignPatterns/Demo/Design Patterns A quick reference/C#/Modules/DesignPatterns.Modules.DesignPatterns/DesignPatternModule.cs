using DesignPatterns.Common;
using DesignPatterns.Modules.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.ServiceLocation;

namespace DesignPatterns.Modules
{
    /// <summary>
    /// 
    /// </summary>
    public class DesignPatternModule : IModule
    {
        /// <summary>
        /// The region manger
        /// </summary>
        IRegionManager regionManager = new RegionManager();

        /// <summary>
        /// The container
        /// </summary>
        IUnityContainer container = new UnityContainer();

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
           //container.RegisterType<IRegionManager, RegionManager>();
            this.regionManager.RegisterViewWithRegion(RegionNames.MainRegion,
                () => ServiceLocator.Current.GetInstance<MainView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.HomeRegion,
             () => ServiceLocator.Current.GetInstance<HeaderView>());
           

            this.regionManager.RegisterViewWithRegion(RegionNames.MainRegion,
             () => ServiceLocator.Current.GetInstance<AdapterView>());
            
        }
    }
}
