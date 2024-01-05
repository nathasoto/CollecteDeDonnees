using Command;
using System;
using System.Windows.Input;
using WPFLignesTransport.Models;

namespace WPFLignesTransport.ViewModels
{
    public class GetPositionGPSViewModel
    {

        //private LignesCollection _linges = new LignesCollection();


        //public LignesCollection Lignes 
        //{ 
        //    get { return _linges; }
        //    set { _linges = value; }

        //}


        public PositionGPSLigne PositionToEdit { get; set; }

        public ICommand ApplyChangesCommand { get; private set; }

        public GetPositionGPSViewModel()
        {
            PositionToEdit = new PositionGPSLigne
            {
                Latitude = "5",
                Longitude = "6",
                Rayon = "7"
            };

            ApplyChangesCommand = new RelayCommand(
            o => ExecuteApplyChangesCommand(),
            o => PositionToEdit.IsValid);
        }

        private void ExecuteApplyChangesCommand()
        {
            // E.g. save your customer to database
        }
    }
}
