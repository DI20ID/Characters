namespace Characters {
    public class DexterityAttribute : Attribute {
        public AcrobaticsAbility Acrobatics { get; set; }
        public SlightOfHandAbility SlightOfHand { get; set; }
        public StealthAbility Stealth { get; set; }
        public DexterityAttribute() {
            Acrobatics = new AcrobaticsAbility();
            SlightOfHand = new SlightOfHandAbility();
            Stealth = new StealthAbility();
        }
        public class AcrobaticsAbility : AbilityProficiency { }
        public class SlightOfHandAbility : AbilityProficiency { }
        public class StealthAbility : AbilityProficiency { }
    }
}
