using System;

namespace Characters {
    public class Weapon : NotificationObject/*, IEquatable<Weapon>*/ { 
        private string? _Weaponname;
        public string? Weaponname { get { return _Weaponname; } set { _Weaponname = value; RaisePropertyChanged(); } }

        private string? _Bonus;
        public string? Bonus { get { return _Bonus; } set { _Bonus = value; RaisePropertyChanged(); } }

        public WeaponAttributeEnum _Attribute { get; set; }
        public string? _Distance;
        public string? Distance { get { return _Distance; } set { _Distance = value; RaisePropertyChanged(); } }

        private bool _Proficiency { get; set; }
        public bool Proficiency { get { return _Proficiency; } set { _Proficiency = value; RaisePropertyChanged(); } }
        public string? _Dice { get; set; }
        public string? Dice { get { return _Dice; } set { _Dice = value; RaisePropertyChanged(); } }

        public Weapon() {

        }

        public Weapon(string? weaponName, string? bonus, WeaponAttributeEnum attribute, string? distance, bool profiency, string? dice) {
            Weaponname = weaponName;
            Bonus = bonus;
            _Attribute = attribute;
            Distance = distance;
            Proficiency = profiency;
            Dice = dice;
        }

        //public bool Equals(Weapon? other) {
        //    if (other == null) return false;
        //    return (this.WeaponName!.Equals(other.WeaponName!));
        //}
    }


}

