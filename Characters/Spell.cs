namespace Characters {
    public class Spell : NotificationObject {
        private string? _Name;
        public string? Name { get { return _Name; } set { _Name = value; RaisePropertyChanged(); } }
        private string? _Description;
        public string? Description { get { return _Description; } set { _Description = value; RaisePropertyChanged(); } }
        private string? _Level;
        public string? Level { get { return _Level; } set { _Level = value; RaisePropertyChanged(); } }
        private string? _Reach;
        public string? Reach { get { return _Reach; } set { _Reach = value; RaisePropertyChanged(); } }
        private string? _Dice;
        public string? Dice { get { return _Dice; } set { _Dice = value; RaisePropertyChanged(); } }
        private bool? _LongRest;
        public bool? RestLong { get { return _LongRest; } set { _LongRest = value; RaisePropertyChanged(); } }
        private bool? _ShortRest;
        public bool? RestShort { get { return _ShortRest; } set { _ShortRest = value; RaisePropertyChanged(); } }
        private string? _SpellUseLevel;
        public string? SpellUseLevel { get { 
                return _SpellUseLevel; } 
            set { _SpellUseLevel = value; 
                RaisePropertyChanged(); } }

        public Spell() {
            if (RestLong == null) RestLong = false;
            if (RestShort == null) RestShort = false;
        }
        public Spell(string? name, string? description, string? level, string? reach, string? dice, bool? longrest, bool? shortrest) {
            Name = name;
            Description = description;
            Level = level;
            Reach = reach;
            Dice = dice;
            RestLong = longrest;
            RestShort = shortrest;
            if (longrest == null) RestLong = false;
            if (shortrest == null) RestShort = false;
        }
    }
}
