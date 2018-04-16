using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using DesignPatterns.Modules.Views;

namespace DesignPatterns.Modules.ViewModels
{
    public class HeaderViewModel : ViewModelBase
    {
        IRegionManager regionManager;
        IServiceLocator serviceLocator;
       
        private DelegateCommand homeCommand;

        private DelegateCommand aboutmeCommand;

        public DelegateCommand HomeCommand
        {
            get
            {
                return (this.homeCommand ?? new DelegateCommand(this.ShowMainView));
            }
        }

        public DelegateCommand AboutmeCommand
        {
            get
            {
                return (this.aboutmeCommand ?? new DelegateCommand(this.AboutView));
            }
        }
        public HeaderViewModel(IRegionManager _regionManager, IServiceLocator _serviceLocator)
        {
            regionManager = _regionManager;
            serviceLocator = _serviceLocator;
        }

        public void ShowMainView()
        {
            var view = ServiceLocator.Current.GetInstance<MainView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }

        public void AboutView()
        {
            var view = ServiceLocator.Current.GetInstance<AboutMeView>();

            var region = this.regionManager.Regions[RegionNames.MainRegion];
            region.Add(view);
            if (region != null)
            {
                region.Activate(view);
            }
        }
    }
}
