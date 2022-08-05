using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Characters {
    public class NotificationObject : INotifyPropertyChanged {
        public void RaisePropertyChanged([CallerMemberName] string? _Name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_Name));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
