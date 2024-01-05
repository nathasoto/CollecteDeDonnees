using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WPFLignesTransport.Models
{
    public class LignesCollection : ObservableCollection<PositionGPSLigne>
    {

    }
    public class PositionGPSLigne : INotifyPropertyChanged
    {
        private String _longitude;
        private String _latitude;
        private String _rayon;
        private bool _isValid;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                if (_longitude != value)
                {
                    _longitude = value;
                    OnPropertyChanged();
                    SetIsValid();
                }
            }
        }

        public string Latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                if (_latitude != value)
                {
                    _latitude = value;
                    OnPropertyChanged();
                    SetIsValid();
                }
            }
        }

        public string Rayon
        {
            get
            {
                return _rayon;
            }
            set
            {
                if (_rayon != value)
                {
                    _rayon = value;
                    OnPropertyChanged();
                    SetIsValid();
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                if (_isValid != value)
                {
                    _isValid = value;
                    OnPropertyChanged();
                }
            }
        }

        private void SetIsValid()
        {
            IsValid = !string.IsNullOrEmpty(Longitude) && !string.IsNullOrEmpty(Latitude) && !string.IsNullOrEmpty(Rayon);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
