namespace Characters {
    public class WisdomAttribute : Attribute {
        public MedicineAbility Medicine { get; set; }
        public AnimalHandlingAbility AnimalHandling { get; set; }
        public InsightAbility Insight { get; set; }
        public SurvivalAbility Survival { get; set; }
        public PerceptionAbility Perception { get; set; }

        public WisdomAttribute() {
            Medicine = new MedicineAbility();
            AnimalHandling = new AnimalHandlingAbility();
            Insight = new InsightAbility();
            Survival = new SurvivalAbility();
            Perception = new PerceptionAbility();
        }
        public class MedicineAbility : AbilityProficiency { }

        public class AnimalHandlingAbility : AbilityProficiency { }

        public class InsightAbility : AbilityProficiency { }

        public class SurvivalAbility : AbilityProficiency { }

        public class PerceptionAbility : AbilityProficiency { }

    }
}
