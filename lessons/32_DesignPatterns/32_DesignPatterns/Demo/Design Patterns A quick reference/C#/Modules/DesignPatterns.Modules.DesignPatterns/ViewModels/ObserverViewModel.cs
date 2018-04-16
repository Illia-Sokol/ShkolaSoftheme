using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public class ObserverViewModel : ViewModelBase
    {
        private string txtManager;
        
        private string txtAdmin;

        public string TxtManager
        {
            get
            {
                return this.txtManager;
            }
            set
            {
                this.txtManager = value;
                this.OnPropertyChanged("TxtManager");
            }
        }
       
        public string TxtAdmin
        {
            get
            {
                return this.txtAdmin;
            }
            set
            {
                this.txtAdmin = value;
                this.OnPropertyChanged("TxtAdmin");
            }
        }

        public ObserverViewModel()
        {
            EmployeeObserver emp = new EmployeeObserver();
            Manager man = new Manager();
            Admin admin = new Admin();
            emp.Register(man);
            emp.Register(admin);
            emp.EditRecord("Updated", "2 record");
            this.TxtManager = man.Record;
            this.TxtAdmin = admin.Record;

        }
    }
}
