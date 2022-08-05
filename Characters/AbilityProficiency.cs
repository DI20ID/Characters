namespace Characters {
    public class AbilityProficiency : NotificationObject {
        private bool _Proficiency { get; set; }
        public bool Proficiency {
            get { return this._Proficiency; }
            set {
                this._Proficiency = value;
                this.RaisePropertyChanged("Proficiency");
            }
        }
        private bool _Expertice { get; set; }
        public bool Expertice {
            get { return this._Expertice; }
            set {
                this._Expertice = value;
                this.RaisePropertyChanged("Expertice");
            }
        }
    }
}
