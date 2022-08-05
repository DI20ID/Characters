namespace Characters {
    public class Attribute : NotificationObject {
        private string? _Value { get; set; }
        public string? Value {
            get { return this._Value; }
            set {
                this._Value = value;
                this.RaisePropertyChanged("Value");
            }
        }
        private bool _SaveThrowProficiency { get; set; }
        public bool SaveThrowProficiency {
            get { return this._SaveThrowProficiency; }
            set {
                this._SaveThrowProficiency = value;
                this.RaisePropertyChanged("SaveThrowProficiency");
            }
        }
    }
}
