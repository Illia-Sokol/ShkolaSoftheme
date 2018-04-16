using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using DesignPatterns.Modules;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;

namespace DesignPatterns
{
    public class DesignPatternBootStrapper : UnityBootstrapper
    {

        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            //moduleCatalog.AddModule(typeof(InfoModule));
            moduleCatalog.AddModule(typeof(DesignPatternModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
    }
}
