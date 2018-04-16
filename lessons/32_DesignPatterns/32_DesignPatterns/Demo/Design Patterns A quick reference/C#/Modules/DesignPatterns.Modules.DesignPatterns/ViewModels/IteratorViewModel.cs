using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using System.Collections.ObjectModel;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public class IteratorViewModel : ViewModelBase
    {

        private ObservableCollection<MonthName> monthsCollection = new ObservableCollection<MonthName>();

        public ObservableCollection<MonthName> MonthsCollection
        {
            get
            {
                return this.monthsCollection;
            }
            set
            {
                this.monthsCollection = value;
                this.OnPropertyChanged("MonthsCollection");
            }
        }
        public IteratorViewModel()
        {
            MonthCollection collection = new MonthCollection();
            foreach (string items in collection)
            {
                this.MonthsCollection.Add(new MonthName { Name = items });
            }
        }
    }

  public class MonthName : ViewModelBase
    {
      private  string name;

      public string Name
      {
          get
          {
              return this.name;
          }
          set
          {
              this.name = value;
              this.OnPropertyChanged("Name");
          }
      }
    }
}
