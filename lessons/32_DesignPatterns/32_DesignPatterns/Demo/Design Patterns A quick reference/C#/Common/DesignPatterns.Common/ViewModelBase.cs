using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DesignPatterns.Common
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handlers = PropertyChanged;

            if (handlers != null)
            {
                handlers(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
