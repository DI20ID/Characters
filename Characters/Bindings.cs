using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Characters {
    public class Bindings {
        public Bindings( ) {


            Init((MainWindow)Application.Current.MainWindow, ((MainWindow)Application.Current.MainWindow).Character, ((MainWindow)Application.Current.MainWindow).LimitedAbilityList, ((MainWindow)Application.Current.MainWindow).WeaponList, ((MainWindow)Application.Current.MainWindow).SpellList, ((MainWindow)Application.Current.MainWindow).ItemList);
        } 
        public void Init(MainWindow window, Character Character, BindingList<LimitedAbility> LimitedAbilityList, BindingList<Weapon>  WeaponList, BindingList<Spell> SpellList, BindingList<Item> ItemList) {
            //Character
            

            window.tb_CharacterName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Class.SetBinding(TextBox.TextProperty, new Binding("Class") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Level.SetBinding(TextBox.TextProperty, new Binding("Level") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Race.SetBinding(TextBox.TextProperty, new Binding("Race") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Background.SetBinding(TextBox.TextProperty, new Binding("Background") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Alignment.SetBinding(TextBox.TextProperty, new Binding("Alignment") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_weigth.SetBinding(TextBox.TextProperty, new Binding("Weigth") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_PlayerName.SetBinding(TextBox.TextProperty, new Binding("PlayerName") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_ExperiencePoints.SetBinding(TextBox.TextProperty, new Binding("Experince") { Source = Character, Mode = BindingMode.TwoWay });
            
            window.tb_ManaPool.SetBinding(TextBox.TextProperty, new Binding("ManaPool") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_UsedMana.SetBinding(TextBox.TextProperty, new Binding("SpentMana") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_ProficencyBonus.SetBinding(TextBox.TextProperty, new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Inspiration.SetBinding(TextBox.TextProperty, new Binding("Inspiration") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_JackOfAllTrades.SetBinding(CheckBox.IsCheckedProperty, new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_JackOfAllTrades.IsChecked = false;
            window.tb_Dice.SetBinding(TextBox.TextProperty, new Binding("Dice.Dice") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_TotalDice.SetBinding(TextBox.TextProperty, new Binding("Dice.Total") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_UsedDice.SetBinding(TextBox.TextProperty, new Binding("Dice.Used") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_Platin.SetBinding(TextBox.TextProperty, new Binding("Platin") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Gold.SetBinding(TextBox.TextProperty, new Binding("Gold") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Electrum.SetBinding(TextBox.TextProperty, new Binding("Electrum") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Silver.SetBinding(TextBox.TextProperty, new Binding("Silver") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Copper.SetBinding(TextBox.TextProperty, new Binding("Copper") { Source = Character, Mode = BindingMode.TwoWay });
            //Attributes

            window.tb_Strength.SetBinding(TextBox.TextProperty, new Binding("Strength.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_StrengthSaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Strength.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AthleticsProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Strength.Athletics.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AthleticsExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Strength.Athletics.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            
            window.tb_Dexterity.SetBinding(TextBox.TextProperty, new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_DexteritySaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AcrobaticsProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.Acrobatics.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AcrobaticsExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.Acrobatics.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_SleightOfHandProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.SlightOfHand.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_SleightOfHandExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.SlightOfHand.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_StealthProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.Stealth.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_StealthExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Dexterity.Stealth.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            
            window.tb_Constitution.SetBinding(TextBox.TextProperty, new Binding("Constitution.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_ConstitutionSaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Constitution.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            
            window.tb_Intelligence.SetBinding(TextBox.TextProperty, new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_IntelligenceSaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_ArcanaProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Arcane.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_ArcanaExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Arcane.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_HistoryProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.History.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_HistoryExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.History.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_InvestigationProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Investigation.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_InvestigationExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Investigation.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_NatureProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Nature.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_NatureExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Nature.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_ReligionProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Religion.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_ReligionExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Intelligence.Religion.Expertice") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_Wisdom.SetBinding(TextBox.TextProperty, new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_WisdomSaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_MedicineProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Medicine.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_MedicineExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Medicine.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AnimalHandlingProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.AnimalHandling.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_AnimalHandlingExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.AnimalHandling.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_InsightProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Insight.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_InsightExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Insight.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_SurvivalProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Survival.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_SurvivalExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Survival.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PerceptionProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Perception.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PerceptionExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Wisdom.Perception.Expertice") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_Charisma.SetBinding(TextBox.TextProperty, new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_CharismaSaveThrow.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.SaveThrowProficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PerformanceProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Performance.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PerformanceExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Performance.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_IntimidationProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Intimidation.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_IntimidationExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Intimidation.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_DeceptionProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Deception.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_DeceptionExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Deception.Expertice") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PersuationProficency.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Persuation.Proficiency") { Source = Character, Mode = BindingMode.TwoWay });
            window.cb_PersuationExpertice.SetBinding(CheckBox.IsCheckedProperty, new Binding("Charisma.Persuation.Expertice") { Source = Character, Mode = BindingMode.TwoWay });

            //Status
            window.tb_ArmorClass.SetBinding(TextBox.TextProperty, new Binding("Status.Armor.Value") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_ArmorBonus.SetBinding(TextBox.TextProperty, new Binding("Status.Armor.Bonus") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Initiative.SetBinding(TextBox.TextProperty, new Binding("Status.Initiative") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_HealthPointsMax.SetBinding(TextBox.TextProperty, new Binding("Status.HealthPoints.Maximum") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_HealthPointsCurrent.SetBinding(TextBox.TextProperty, new Binding("Status.HealthPoints.Current") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_HealthPointsTemp.SetBinding(TextBox.TextProperty, new Binding("Status.HealthPoints.Temporary") { Source = Character, Mode = BindingMode.TwoWay });

            window.tb_Exaustion.SetBinding(TextBox.TextProperty, new Binding("Status.Exaustion") { Source = Character, Mode = BindingMode.TwoWay });

            window.cb_Darksight.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.Darksight") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Darksight.SetBinding(TextBox.TextProperty, new Binding("Status.DarksightDistance") { Source = Character, Mode = BindingMode.TwoWay });
            window.tb_Speed.SetBinding(TextBox.TextProperty, new Binding("Status.Speed") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_Darksight.IsChecked = false;

            window.cb_DeathSavesSuccesses1.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Successes1") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesSuccesses1.IsChecked = false;
            window.cb_DeathSavesSuccesses2.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Successes2") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesSuccesses2.IsChecked = false;
            window.cb_DeathSavesSuccesses3.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Successes3") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesSuccesses3.IsChecked = false;
            window.cb_DeathSavesFailures1.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Failures1") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesFailures1.IsChecked = false;
            window.cb_DeathSavesFailures2.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Failures2") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesFailures2.IsChecked = false;
            window.cb_DeathSavesFailures3.SetBinding(CheckBox.IsCheckedProperty, new Binding("Status.DeathSaves.Failures3") { Source = Character, Mode = BindingMode.TwoWay }); window.cb_DeathSavesFailures3.IsChecked = false;


            //Cahracter Attributes
            window.l_Strength.SetBinding(Label.ContentProperty, new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            window.l_Dexterity.SetBinding(Label.ContentProperty, new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            window.l_Constitution.SetBinding(Label.ContentProperty, new Binding("Constitution.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            window.l_Intelligence.SetBinding(Label.ContentProperty, new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            window.l_Wisdom.SetBinding(Label.ContentProperty, new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            window.l_Charisma.SetBinding(Label.ContentProperty, new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });


            //Character SaveThrows
            window.l_StrengthSTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Strength.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });
            window.l_DexteritySTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });
            window.l_ConstitutionSTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Constitution.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Constitution.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });
            window.l_IntelligenceSTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });
            window.l_WisdomSTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });
            window.l_CharismaSTBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.SaveThrowProficiency") { Source = Character, Mode = BindingMode.OneWay } },
                Converter = new SaveThrowProficiencyConvert()
            });

            //Character.Strength.Athletics
            window.l_AthleticsBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Strength.Athletics.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Strength.Athletics.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Dexterity.Acrobatics
            window.l_AcrobaticsBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.Acrobatics.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.Acrobatics.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Dexterity.SlightOfHand
            window.l_SleightOfHandBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.SlightOfHand.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.SlightOfHand.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Dexterity.Stealth
            window.l_StealthBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Dexterity.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.Stealth.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Dexterity.Stealth.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Intelligence.Arcane
            window.l_ArcanaBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Arcane.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Arcane.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Intelligence.History
            window.l_HistoryBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.History.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.History.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Intelligence.Investigation
            window.l_InvestigationBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Investigation.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Investigation.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Intelligence.Nature
            window.l_NatureBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Nature.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Nature.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Intelligence.Religion
            window.l_ReligionBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Intelligence.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Religion.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Intelligence.Religion.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Wisdom.Medicine
            window.l_MedicineBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Medicine.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Medicine.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Wisdom.AnimalHandling
            window.l_AnimalHandlingBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.AnimalHandling.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.AnimalHandling.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Wisdom.Insight
            window.l_InsightBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Insight.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Insight.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()

            });
            //Character.Wisdom.Survival
            window.l_SurvivalBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Survival.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Survival.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Wisdom.Perception
            window.l_PerceptionBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Wisdom.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Perception.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Wisdom.Perception.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            // Character.Charisma.Performance
            window.l_PerformanceBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Performance.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Performance.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            //Character.Charisma.Intimidation
            window.l_IntimidationBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Intimidation.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Intimidation.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            // Character.Charisma.Deception
            window.l_DeceptionBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Deception.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Deception.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            // Character.Charisma.Persuation
            window.l_PersuationBonus.SetBinding(Label.ContentProperty, new MultiBinding() {
                Bindings = {
                    new Binding("Charisma.Value") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("ProficiencyBonus") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("JackOfAllTraides") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Persuation.Proficiency") { Source = Character, Mode = BindingMode.OneWay },
                    new Binding("Charisma.Persuation.Expertice") { Source = Character, Mode = BindingMode.OneWay }},
                Converter = new Converters()
            });
            window.l_JackofallTrades.SetBinding(Label.ContentProperty, new Binding("ProficiencyBonus") {
                Source = Character,
                Mode = BindingMode.OneWay,
                Converter = new JackofallTraidesConvert()
            });

            window.WeaponGrid.DataContext = WeaponList;
            window.WeaponGrid.ItemsSource = WeaponList;
            window.WeaponName.Binding = new Binding("Weaponname") { Mode = BindingMode.TwoWay };
            window.WeaponBonus.Binding = new Binding("Bonus") { Mode = BindingMode.TwoWay, NotifyOnTargetUpdated = true, NotifyOnSourceUpdated = true };

            window.WeaponAttribute.SelectedItemBinding = new Binding("_Attribute") { Mode = BindingMode.TwoWay };
            window.WeaponReach.Binding = new Binding("Distance") { Mode = BindingMode.TwoWay };
            
            window.WeaponDice.Binding = new Binding("Dice") { Mode = BindingMode.TwoWay };
            //Todo add Attribute modifier
            window.WeaponAttack.Binding = new MultiBinding() {
                Bindings = {
                    new Binding("Bonus"),
                    new Binding("Dice"),
                    new Binding("Proficiency"),
                    new Binding("ProficiencyBonus") { Source = Character, },
                    new Binding("_Attribute"),
                    new Binding("Strength.Value") { Source = Character },
                    new Binding("Dexterity.Value") { Source = Character },
                },
                Converter = new WeaponAttackConvert(),
            };
            window.WeaponDamage.Binding = new MultiBinding() {
                Bindings = {
                    new Binding("Bonus") { Mode = BindingMode.TwoWay },
                    new Binding("Dice") { Mode = BindingMode.TwoWay },
                    new Binding("_Attribute"),
                    new Binding("Strength.Value") { Source = Character },
                    new Binding("Dexterity.Value") { Source = Character },
                },
                Converter = new WeaponDamageConvert()
            };

            window.LimitedAbilityGrid.DataContext = LimitedAbilityList;
            window.LimitedAbilityGrid.ItemsSource = LimitedAbilityList;
            window.LimitedAbilityName.Binding = new Binding("Name") { Mode = BindingMode.TwoWay };
            //window.LimitedAbilityDescription.Binding = new Binding("Description") { Mode = BindingMode.TwoWay };
            window.LimitedAbilityTotal.Binding = new Binding("TotalUses") { Mode = BindingMode.TwoWay };

            window.SpellGrid.DataContext = SpellList;
            window.SpellGrid.ItemsSource = SpellList;
            window.SpellName.Binding = new Binding("Name") { Mode = BindingMode.TwoWay };
            window.SpellDescription.Binding = new Binding("Description") { Mode = BindingMode.TwoWay };
            window.SpellLevel.Binding = new Binding("Level") { Mode = BindingMode.TwoWay };
            window.SpellReach.Binding = new Binding("Reach") { Mode = BindingMode.TwoWay };
            
            window.SpellDice.Binding = new Binding("Dice") { Mode = BindingMode.TwoWay };
           


            window.ItemsGrid.DataContext = ItemList;
            window.ItemsGrid.ItemsSource = ItemList;
            window.ItemName.Binding = new Binding("Name") { Mode = BindingMode.TwoWay };
            //window.ItemDescription.Binding = new Binding("Description") { Mode = BindingMode.TwoWay };
            window.ItemCost.Binding = new Binding("Worth") { Mode = BindingMode.TwoWay };
            window.ItemWeigth.Binding = new Binding("Weigth") { Mode = BindingMode.TwoWay };
            
            window.tbl_weigthcharacterwithinventory.SetBinding(TextBlock.TextProperty, new Binding("Weigth") { Source = Character, Mode = BindingMode.OneWay, Converter = new characterwithinvenoryweight() });
            window.tbl_weigthburdend.SetBinding (TextBlock.TextProperty, new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new burdendConverter() });
            window.tbl_weigthheavilyburdend.SetBinding(TextBlock.TextProperty, new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new heavilyburdendConverter() });
            //  window.l_Strength.SetBinding(Label.ContentProperty, new Binding("Strength.Value") { Source = Character, Mode = BindingMode.OneWay, Converter = new AttributeBonusConvert() });
            // window.tbl_weigthinpound.DataContext = window.ItemWeigth;
            // window.tbl_weigthinpound.SetBinding(TextBlock.TextProperty, new Binding("Weigth") { Source = ItemList, Mode = BindingMode.TwoWay, NotifyOnSourceUpdated = true, Converter = new InventoryWeigthConvert() });
        }
    }
}
