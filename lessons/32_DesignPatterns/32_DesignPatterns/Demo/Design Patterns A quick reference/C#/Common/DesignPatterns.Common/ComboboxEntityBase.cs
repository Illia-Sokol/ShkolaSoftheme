using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Common
{
    public class ComboboxEntityBase<T> : ViewModelBase
    {
        private int id;
        private string Name;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
                this.OnPropertyChanged("ID");
            }
        }
    }
}
