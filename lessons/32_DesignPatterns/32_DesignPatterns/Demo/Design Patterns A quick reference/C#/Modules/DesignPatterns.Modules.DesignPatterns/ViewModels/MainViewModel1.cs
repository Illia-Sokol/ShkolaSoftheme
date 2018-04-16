using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using Microsoft.Practices.Prism.Commands;

namespace DesignPatterns.Modules.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        #region Private Properties
        private DelegateCommand adapterCommand;

        private DelegateCommand decoratorCommand;

        private DelegateCommand proxyCommand;

        private DelegateCommand bridgeCommand;

        private DelegateCommand serviceLocatorCommand;

        private DelegateCommand facadeCommand;

        private DelegateCommand prototypeCommand;

        private DelegateCommand factoryMethodCommand;

        private DelegateCommand mvpCommand;

        private DelegateCommand commandPatternCommand;
        private DelegateCommand iteratorCommand;

        private DelegateCommand visitorCommand;

        private DelegateCommand observerCommand;

        private DelegateCommand singletonCommand;

        private DelegateCommand mvcCommand;
        #endregion

        #region Public Properties

        public DelegateCommand AdapterCommand
        {
            get
            {
                return (this.adapterCommand ?? new DelegateCommand(this.OpenAdapterView));
            }
        }

        public DelegateCommand DecoratorCommand
        {
            get
            {
                return (this.decoratorCommand ?? new DelegateCommand(this.OpenDecoratorView));
            }
        }

        public DelegateCommand ProxyCommand
        {
            get
            {
                return (this.proxyCommand ?? new DelegateCommand(this.OpenProxyView));
            }
        }

        public DelegateCommand BridgeCommand
        {
            get
            {
                return (this.bridgeCommand ?? new DelegateCommand(this.OpenBridgeView));
            }
        }

        public DelegateCommand ServiceLocatorCommand
        {
            get
            {
                return (this.serviceLocatorCommand ?? new DelegateCommand(this.OpenServiceLocatorView));
            }
        }

        public DelegateCommand FacadeCommand
        {
            get
            {
                return (this.facadeCommand
                    ?? new DelegateCommand(this.OpenFacadeView));
            }
        }

        public DelegateCommand PrototypeCommand
        {
            get
            {
                return (this.prototypeCommand
                    ?? new DelegateCommand(this.OpenPrototypeView));
            }
        }

        public DelegateCommand FactoryMethodCommand
        {
            get
            {
                return (this.factoryMethodCommand
                    ?? new DelegateCommand(this.OpenFactoryMethodView));
            }
        }

        public DelegateCommand MVPCommand
        {
            get
            {
                return (this.mvpCommand
                    ?? new DelegateCommand(this.OpenMVPView));
            }
        }
        public DelegateCommand CommandPatternCommand
        {
            get
            {
                return (this.commandPatternCommand
                    ?? new DelegateCommand(this.OpenCommandView));
            }
        }
        public DelegateCommand IteratorCommand
        {
            get
            {
                return (this.iteratorCommand
                    ?? new DelegateCommand(this.OpenIteratorView));
            }
        }

        public DelegateCommand VisitorCommand
        {
            get
            {
                return (this.visitorCommand
                    ?? new DelegateCommand(this.OpenVisitorView));
            }
        }
        public DelegateCommand ObserverCommand
        {
            get
            {
                return (this.observerCommand
                    ?? new DelegateCommand(this.OpenObserverView));
            }
        }

        public DelegateCommand SingletonCommand
        {
            get
            {
                return (this.singletonCommand
                    ?? new DelegateCommand(this.OpenSingletonView));
            }
        }

        public DelegateCommand MvcCommand
        {
            get
            {
                return (this.mvcCommand
                    ?? new DelegateCommand(this.OpenMVCView));
            }
        }
        #endregion
    }
}
