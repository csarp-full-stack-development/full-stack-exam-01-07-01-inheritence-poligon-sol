using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SokszogProjekt.NezetModel
{
    // https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-property-change-notification
    public class ViewModelBase : INotifyPropertyChanged
    {
       public event PropertyChangedEventHandler? PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

}
