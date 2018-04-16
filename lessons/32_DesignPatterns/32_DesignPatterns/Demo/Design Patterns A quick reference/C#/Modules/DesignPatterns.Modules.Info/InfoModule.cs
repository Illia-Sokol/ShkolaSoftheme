using DesignPatterns.Common;
using DesignPatterns.Modules.Info.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;

namespace DesignPatterns.Modules.Info
{
    public class InfoModule : IModule
    {
        /// <summary>
        /// The region manager
        /// </summary>
        IRegionManager regionManager;

        /// <summary>
        /// The container
        /// </summary>
        IUnityContainer container;


        public InfoModule(IRegionManager _regionManager, IUnityContainer _container)
        {
            regionManager = _regionManager;
            container = _container;
        }
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion(RegionNames.HomeRegion, () => this.container.Resolve<InfoView>());
            container.RegisterType<IEventAggregator, EventAggregator>();
        }
    }
}
