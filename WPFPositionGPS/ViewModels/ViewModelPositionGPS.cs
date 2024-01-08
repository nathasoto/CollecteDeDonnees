using Command;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using WPFPositionGPS.Models;

namespace WPFPositionGPS.ViewModels
{
    public class ViewModelPositionGPS : INotifyPropertyChanged
    {
        private  PositionGPS positionGPS;

        public double Latitude
        {
            get { return positionGPS.Latitude; }
            set
            {
                if (positionGPS.Latitude != value)
                {
                    positionGPS.Latitude = value;
                    OnPropertyChange("Latitude");
                    OnPropertyChange("Information");

                }
            }
        }
        public double Longitude
        {
            get { return positionGPS.Longitud; }
            set
            {
                if (positionGPS.Longitud != value)
                {
                    positionGPS.Longitud = value;
                    OnPropertyChange("Longitude");
                    OnPropertyChange("Information");

                }
            }
        }

        public int Rayon
        {
            get { return positionGPS.Rayon; }
            set
            {
                if (positionGPS.Rayon != value)
                {
                    positionGPS.Rayon = value;
                    OnPropertyChange("Rayon");
                    OnPropertyChange("Information");

                }
            }
        }

        private Visibility _visibility = Visibility.Hidden;

        public Visibility Visibility
        {
            get => _visibility;
            set { if (_visibility != value)
                {
                    _visibility = value;
                    OnPropertyChange("Visibility");
                }
            }
        }

        private ICommand _findCommand;
        public ICommand FindCommand
        {
            get => _findCommand ?? (_findCommand = new RelayCommand(o => 
            {
                Visibility = Visibility.Visible;
                OnPropertyChange("Information");
            },
                o => true));
            set => _findCommand = value;
        }

        public string Information
        {
            get { return Latitude + " - " + Longitude + " - " + Rayon; }
        }

        public ViewModelPositionGPS()
        {
            positionGPS = new PositionGPS
            {
                Latitude = 5.731358767949209,
                Longitud = 45.18457681950622,
                Rayon = 400,

            };
           
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
