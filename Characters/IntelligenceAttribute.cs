namespace Characters {
    public class IntelligenceAttribute : Attribute {
        public ArcaneAbility Arcane { get; set; }
        public HistoryAbility History { get; set; }
        public InvestigationAbility Investigation { get; set; }
        public NatureAbility Nature { get; set; }
        public ReligionAbility Religion { get; set; }
        public IntelligenceAttribute() {
            Arcane = new ArcaneAbility();
            History = new HistoryAbility();
            Investigation = new InvestigationAbility();
            Nature = new NatureAbility();
            Religion = new ReligionAbility();
        }
        public class ArcaneAbility : AbilityProficiency { }
        public class HistoryAbility : AbilityProficiency { }
        public class InvestigationAbility : AbilityProficiency { }
        public class NatureAbility : AbilityProficiency { }
        public class ReligionAbility : AbilityProficiency { }
    }
}
