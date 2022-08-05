namespace Characters {
    public class StrengthAttribute : Attribute {
        public AthleticsAbility Athletics { get; set; }
        public StrengthAttribute() {
            Athletics = new AthleticsAbility();
        }
        public class AthleticsAbility : AbilityProficiency { }
    }
}
