namespace Characters {
    public class LimitedAbility : NotificationObject {
        private string? _Name;
        public string? Name { get { return _Name; } set { _Name = value; RaisePropertyChanged(); } }
        private string? _Description;
        public string? Description { get { return _Description; } set { _Description = value; RaisePropertyChanged(); } }

        private bool? _RestLong;
        public bool? RestLong { get { return _RestLong; } set { _RestLong = value; RaisePropertyChanged(); } }
        private bool? _RestShort;
        public bool? RestShort { get { return _RestShort; } set { _RestShort = value; RaisePropertyChanged(); } }


        private string? _TotalUses;
        public string? TotalUses { get { return _TotalUses; } set { _TotalUses = value; RaisePropertyChanged(); } }
        private string? _Used;
        public string? Used { get { return _Used; } set { _Used = value; RaisePropertyChanged(); } }
        public LimitedAbility() {
            if (RestLong == null) RestLong = false;
            if (RestShort == null) RestShort = false;
        }
        public LimitedAbility(string? name, string? description, bool? restlong, bool? restshort, string totalusses, string used) {
            Name = name;
            Description = description;
            RestLong = restlong;
            RestShort = restshort;
            TotalUses = totalusses;
            Used = used;
            if (restlong == null) RestLong = false;
            if (restshort == null) RestShort = false;
        }
    }
}
