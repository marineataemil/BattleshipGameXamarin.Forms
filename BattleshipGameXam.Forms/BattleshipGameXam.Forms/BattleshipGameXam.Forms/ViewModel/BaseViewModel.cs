using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BattleshipGameXam.Forms.ViewModel
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(propertyName == null || PropertyChanged == null)
            {
                return;
            }

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
