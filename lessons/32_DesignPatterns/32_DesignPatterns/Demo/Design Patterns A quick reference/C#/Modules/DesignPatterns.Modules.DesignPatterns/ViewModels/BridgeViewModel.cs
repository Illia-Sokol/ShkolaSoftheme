using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Common;
using DesignPatterns.Modules.Models;

namespace DesignPatterns.Modules.ViewModels
{
    public class BridgeViewModel : ViewModelBase
    {
        private string txtFormat;

        public string TxtFormat
        {
            get
            {
                return this.txtFormat;
            }
            set
            {
                this.txtFormat = value;
                this.OnPropertyChanged("TxtFormat");
            }
        }

        public BridgeViewModel()
        {
            ICurrenyFormatter format = new UsCurrency();
            Formatter formatter = new RefinedFormatter(format);
            string Text = "100";
            TxtFormat = formatter.FormatOperation(Text);
        }
    }
}
