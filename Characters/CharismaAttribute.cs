namespace Characters {
    public class CharismaAttribute : Attribute {
        public PerformanceAbility Performance { get; set; }
        public IntimidationAbility Intimidation { get; set; }
        public DeceptionAbility Deception { get; set; }
        public PersuationAbility Persuation { get; set; }

        public CharismaAttribute() {
            this.Performance = new PerformanceAbility();
            this.Intimidation = new IntimidationAbility();
            this.Deception = new DeceptionAbility();
            this.Persuation = new PersuationAbility();
        }
        public class PerformanceAbility : AbilityProficiency { }

        public class IntimidationAbility : AbilityProficiency { }

        public class DeceptionAbility : AbilityProficiency { }

        public class PersuationAbility : AbilityProficiency { }

    }
}
