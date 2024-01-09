using CollecteDeDonnees;
using Command;
using LibraryDonnesAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using WPFPositionGPS.Models;

namespace WPFPositionGPS.ViewModels
{


    public class ViewModelPositionGPS : INotifyPropertyChanged
    {
        private PositionGPS positionGPS;
        private DonneLibrary donneLibrary = new DonneLibrary();

        private ObservableCollection<LineDonne> _lines = new ObservableCollection<LineDonne>();
        public ObservableCollection<LineDonne> Lines {
            get { return _lines; }
            set { _lines = value; }
        }

        public double Latitude
        {
            get { return positionGPS.Latitude; }
            set
            {
                 
                if(positionGPS.Latitude != value )
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
                if (positionGPS.Rayon != value )
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
            set
            {
                if (_visibility != value)
                {
                    _visibility = value;
                    OnPropertyChange("Visibility");
                }
            }
        }



        private ICommand _findLines;

        public ICommand FindLines
        {
            get => _findLines ?? (_findLines = new RelayCommand(o =>
            {

                GetCoordinates();
                Visibility = Visibility.Visible;
                OnPropertyChange("Information");
            },
                o => true));
            set => _findLines = value;
        }

        public string Information
        {
            get { return  "Longitud : " + Longitude.ToString(System.Globalization.CultureInfo.InvariantCulture) + "     Latitude : " + Latitude.ToString(System.Globalization.CultureInfo.InvariantCulture) + "    Rayon : " + Rayon; }
        }

        private void GetCoordinates()
        {
            if (Latitude != 0 && Longitude != 0 && Rayon !=0)
            {
                List<LineDonne> lineDonnes = donneLibrary.FindLines(Longitude.ToString(System.Globalization.CultureInfo.InvariantCulture), Latitude.ToString(System.Globalization.CultureInfo.InvariantCulture), Rayon.ToString());
                Lines.Clear();
                foreach (LineDonne lineDonne in lineDonnes)
                {
                    _lines.Add(lineDonne);

                }

            }
            else
            {
                MessageBox.Show("cannot be zero");
            } 

        }
        
     
        public ViewModelPositionGPS()
        {
            positionGPS = new PositionGPS
            {
                
            };
   
            Longitude = 5.731358767949209;
            Latitude = 45.18457681950622;
            Rayon = 400;

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
