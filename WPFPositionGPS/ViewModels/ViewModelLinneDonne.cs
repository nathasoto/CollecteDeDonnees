using CollecteDeDonnees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPositionGPS.Models;

namespace WPFPositionGPS.ViewModels
{
    public class ViewModelLinneDonne : INotifyPropertyChanged
    {

        private LineDonne lineDonne;

        public String Id
        {
            get { return lineDonne.id; }
            set
            {
                if (lineDonne.id != value)
                {
                    lineDonne.id = value;
                    OnPropertyChange("Id");
                    OnPropertyChange("Lines");

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
