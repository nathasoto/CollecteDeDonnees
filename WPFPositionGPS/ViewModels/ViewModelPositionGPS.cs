using System.ComponentModel;

namespace WPFPositionGPS.ViewModels
{
    public class ViewModelPositionGPS : INotifyPropertyChanged
    {
        private float _latitude;
        private float _lonitude;
        private int _rayon;

        public float Latitude
        {
            get { return _latitude; }
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    OnPropertyChange("Latitude");
                    OnPropertyChange("Information");

                }
            }
        }
        public float Longitude
        {
            get { return _lonitude; }
            set
            {
                if (_lonitude != value)
                {
                    _lonitude = value;
                    OnPropertyChange("Longitude");
                    OnPropertyChange("Information");

                }
            }
        }

        public int Rayon
        {
            get { return _rayon; }
            set
            {
                if (_rayon != value)
                {
                    _rayon = value;
                    OnPropertyChange("Rayon");
                    OnPropertyChange("Information");

                }
            }
        }

        public string Information
        {
            get { return Latitude + " " + Longitude; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
