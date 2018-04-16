using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism.Events;
using DesignPatterns.Common.Events;

namespace DesignPatterns.Modules.Info.ViewModels
{
    public class InfoViewModel : ViewModelBase
    {
        IEventAggregator eventAggrator;
        public InfoViewModel(IEventAggregator _eventAggrator)
        {
            this.eventAggrator = _eventAggrator;
           
        }
        private DelegateCommand homeCommand;

        public DelegateCommand HomeCommand
        {
            get
            {
                return (this.homeCommand ?? new DelegateCommand(this.ShowMainView));
            }
        }

        private void ShowMainView()
        {
            this.eventAggrator.GetEvent<MainViewEvent>().Publish(true);
        }
    }
}
