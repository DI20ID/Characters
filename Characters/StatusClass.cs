namespace Characters {
    public class StatusClass : NotificationObject {
        private string? _Initiative;
        public string? Initiative { get { return _Initiative; } set { _Initiative = value; RaisePropertyChanged(); } }
        private ArmorClass? _Armor;
        public ArmorClass Armor { get { return _Armor!; } set { _Armor = value; RaisePropertyChanged(); } }
        private HealthClass? _HealthPoints;
        public HealthClass HealthPoints { get { return _HealthPoints!; } set { _HealthPoints = value; RaisePropertyChanged(); } }

        private DeathSaveClass? _DeathSaves;
        public DeathSaveClass DeathSaves { get { return _DeathSaves!; } set { _DeathSaves = value; RaisePropertyChanged(); } }

        public StatusClass() {
            Armor = new ArmorClass();
            HealthPoints = new HealthClass();
            
            DeathSaves = new DeathSaveClass();
        }
        public class ArmorClass : NotificationObject {
            private string? _Value;
            public string? Value { get { return _Value; } set { _Value = value; RaisePropertyChanged(); } }
            private string? _Bonus;
            public string? Bonus { get { return _Bonus; } set { _Bonus = value; RaisePropertyChanged(); } }
        }
        public class HealthClass : NotificationObject {
            private string? _Maximum;
            public string? Maximum { get { return _Maximum; } set { _Maximum = value; RaisePropertyChanged(); } }
            private string? _Current;
            public string? Current { get { return _Current; } set { _Current = value; RaisePropertyChanged(); } }
            private string? _Temporary;
            public string? Temporary { get { return _Temporary; } set { _Temporary = value; RaisePropertyChanged(); } }
        }
        private string? _Exaustion;
        public string? Exaustion { get { return _Exaustion; } set { _Exaustion = value; RaisePropertyChanged(); } }

        private bool? _Darksight;
        public bool? Darksight { get { return _Darksight; } set { _Darksight = value; RaisePropertyChanged(); } }
        private string? _Distance;
        public string? DarksightDistance { get { return _Distance; } set { _Distance = value; RaisePropertyChanged(); } }

        private string? _Speed;
        public string? Speed { get { return _Speed; } set { _Speed = value; RaisePropertyChanged(); } }
        
        public class DeathSaveClass : NotificationObject {
            private bool? _Successes1;
            public bool? Successes1 { get { return _Successes1; } set { _Successes1 = value; RaisePropertyChanged(); } }
            private bool? _Successes2;
            public bool? Successes2 { get { return _Successes2; } set { _Successes2 = value; RaisePropertyChanged(); } }
            private bool? _Successes3;
            public bool? Successes3 { get { return _Successes3; } set { _Successes3 = value; RaisePropertyChanged(); } }
            private bool? _Failures1;
            public bool? Failures1 { get { return _Failures1; } set { _Failures1 = value; RaisePropertyChanged(); } }
            private bool? _Failures2;
            public bool? Failures2 { get { return _Failures2; } set { _Failures2 = value; RaisePropertyChanged(); } }
            private bool? _Failures3;
            public bool? Failures3 { get { return _Failures3; } set { _Failures3 = value; RaisePropertyChanged(); } }
        }
    }
}
