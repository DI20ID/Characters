using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Characters {
    public class Character : NotificationObject {

        private string? _Name;
        public string? Name { get { return _Name; } set { _Name = value; RaisePropertyChanged(); } }
        private string? _Class;
        public string? Class { get { return _Class; } set { _Class = value; RaisePropertyChanged(); } }
        private string? _Level;
        public string? Level { get { return _Level; } set { _Level = value; RaisePropertyChanged(); } }
        private string? _Background;
        public string? Background { get { return _Background; } set { _Background = value; RaisePropertyChanged(); } }
        private string? _Race;
        public string? Race { get { return _Race; } set { _Race = value; RaisePropertyChanged(); } }
        private string? _Alignment;
        public string? Alignment { get { return _Alignment; } set { _Alignment = value; RaisePropertyChanged(); } }
        private string? _Weigth;
        public string? Weigth { get { return _Weigth; } set { _Weigth = value; RaisePropertyChanged(); } }
        private string? _PlayerName;
        public string? PlayerName { get { return _PlayerName; } set { _PlayerName = value; RaisePropertyChanged(); } }
        private string? _Experince;
        public string? Experince { get { return _Experince; } set { _Experince = value; RaisePropertyChanged(); } }
        private string? _ProficiencyBonus;
        public string? ProficiencyBonus { get { return _ProficiencyBonus; } set { _ProficiencyBonus = value; RaisePropertyChanged(); } }
        private string? _Inspiration;
        public string? Inspiration { get { return _Inspiration; } set { _Inspiration = value; RaisePropertyChanged(); } }
        private bool? _JackOfAllTraides;
        public bool? JackOfAllTraides { get { return _JackOfAllTraides; } set { _JackOfAllTraides = value; RaisePropertyChanged(); } }
        private StatusClass? _Status;
        public StatusClass Status { get { return _Status!; } set { _Status = value; RaisePropertyChanged(); } }
        public List<Weapon> WeaponList { get; set; }
        public List<LimitedAbility> LimitedAbilityList { get; set; }
        public List<Spell> SpellList { get; set; }
        public List<Item> ItemList { get; set; }

        private StrengthAttribute? _Strength;
        public StrengthAttribute Strength { get { return _Strength!; } set { _Strength = value; RaisePropertyChanged(); } }
        private DexterityAttribute? _Dexterity;
        public DexterityAttribute Dexterity { get { return _Dexterity!; } set { _Dexterity = value; RaisePropertyChanged(); } }
        private ConstitutionAttribute? _Constitution;
        public ConstitutionAttribute Constitution { get { return _Constitution!; } set { _Constitution = value; RaisePropertyChanged(); } }
        private IntelligenceAttribute? _Intelligence;
        public IntelligenceAttribute Intelligence { get { return _Intelligence!; } set { _Intelligence = value; RaisePropertyChanged(); } }
        private WisdomAttribute? _Wisdom;
        public WisdomAttribute Wisdom { get { return _Wisdom!; } set { _Wisdom = value; RaisePropertyChanged(); } }
        private CharismaAttribute? _Charisma;
        public CharismaAttribute Charisma { get { return _Charisma!; } set { _Charisma = value; RaisePropertyChanged(); } }
        private HitDice? _Dice;
        public HitDice Dice { get { return _Dice!; } set { _Dice = value; RaisePropertyChanged(); } } 
        private string? _ManaPool;
        public string? ManaPool { get { return _ManaPool; } set { _ManaPool = value; RaisePropertyChanged(); } }

        private string? _SpentMana;
        public string? SpentMana { get { return _SpentMana; } set { _SpentMana = value; RaisePropertyChanged(); } }
        private string? _Platin;
        public string? Platin { get { return _Platin; } set { _Platin = value; RaisePropertyChanged(); } }
        private string? _Gold;
        public string? Gold { get { return _Gold; } set { _Gold = value; RaisePropertyChanged(); } }
        private string? _Electrum;
        public string? Electrum { get { return _Electrum; } set { _Electrum = value; RaisePropertyChanged(); } }
        private string? _Silver;
        public string? Silver { get { return _Silver; } set { _Silver = value; RaisePropertyChanged(); } }
        private string? _Copper;
        public string? Copper { get { return _Copper; } set { _Copper = value; RaisePropertyChanged(); } }


        public Character() {

            Status = new StatusClass();
            WeaponList = new List<Weapon>();
            LimitedAbilityList = new List<LimitedAbility>();
            ItemList = new List<Item>();
            WeaponList = new List<Weapon>();
            SpellList = new List<Spell>();
            Strength = new StrengthAttribute();
            Dexterity = new DexterityAttribute();
            Constitution = new ConstitutionAttribute();
            Intelligence = new IntelligenceAttribute();
            Wisdom = new WisdomAttribute();
            Charisma = new CharismaAttribute();
            Dice = new HitDice();
            
        }
        public Character(string? key,string? name, string? @class, string? level, string? background, string? race, string? alignment, string? playerName, string? experince, string? proficiencyBonus, string? inspiration, bool jackofalltraides, StatusClass status, List<Weapon> weaponList, List<LimitedAbility> abilityList, List<Item> items, StrengthAttribute strength, DexterityAttribute dexterity, ConstitutionAttribute constitution, IntelligenceAttribute intelligence, WisdomAttribute wisdom, CharismaAttribute charisma) {
           
            Name = name;
            Class = @class;
            Level = level;
            Background = background;
            Race = race;
            Alignment = alignment;
            PlayerName = playerName;
            Experince = experince;
            ProficiencyBonus = proficiencyBonus;
            Inspiration = inspiration;
            JackOfAllTraides = jackofalltraides;
            Status = status;
            WeaponList = weaponList;
            LimitedAbilityList = abilityList;
            ItemList = items;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;

        }
        public class HitDice : NotificationObject {
            private string? _Dice;
            public string? Dice { get { return _Dice; } set { _Dice = value; RaisePropertyChanged(); } }
            private string? _Total;
            public string? Total { get { return _Total; } set { _Total = value; RaisePropertyChanged(); } }
            private string? _Used;
            public string? Used { get { return _Used; } set { _Used = value; RaisePropertyChanged(); } }
        }
        public void ChangeTo(Character changeto) {
            
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties) {
                if (property.GetValue(changeto) == null)
                    property.SetValue(this,"0");
                else
                property.SetValue(this, property.GetValue(changeto));
               
            }
            
        }
    }
}
