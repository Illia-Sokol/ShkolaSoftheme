using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using DesignPatterns.Modules.Views;
using DesignPatterns.Common.Events;
using Microsoft.Practices.Prism.Events;

namespace DesignPatterns.Modules.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        IRegionManager regionManager;
        IServiceLocator serviceLocator;
        IEventAggregator eventAggregator;

        public MainViewModel(IRegionManager _regionManager, IServiceLocator _serviceLocator)
        {
            regionManager = _regionManager;
            serviceLocator = _serviceLocator;
           
        }


        #region Public Methods
       
        public void ShowMainView(bool value)
        {
            var view = ServiceLocator.Current.GetInstance<MainView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenAdapterView()
        {

            var view = ServiceLocator.Current.GetInstance<AdapterView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenDecoratorView()
        {

            var view = ServiceLocator.Current.GetInstance<DecoratorView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenProxyView()
        {

            var view = ServiceLocator.Current.GetInstance<ProxyView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenBridgeView()
        {

            var view = ServiceLocator.Current.GetInstance<BridgeView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }


        public void OpenServiceLocatorView()
        {

            var view = ServiceLocator.Current.GetInstance<ServiceLocatorView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenFacadeView()
        {
            var view = ServiceLocator.Current.GetInstance<FacadeView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenPrototypeView()
        {
            var view = ServiceLocator.Current.GetInstance<PrototypeView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenFactoryMethodView()
        {
            var view = ServiceLocator.Current.GetInstance<FactoryMethodView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenMVPView()
        {
            var view = ServiceLocator.Current.GetInstance<MvpView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenCommandView()
        {
            var view = ServiceLocator.Current.GetInstance<CommandView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenIteratorView()
        {
            var view = ServiceLocator.Current.GetInstance<IteratorView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenVisitorView()
        {
            var view = ServiceLocator.Current.GetInstance<VisitorView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenObserverView()
        {
            var view = ServiceLocator.Current.GetInstance<ObserverView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenSingletonView()
        {
            var view = ServiceLocator.Current.GetInstance<SingletonView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void OpenMVCView()
        {
            var view = ServiceLocator.Current.GetInstance<MvcView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }
        #endregion
    }
}
