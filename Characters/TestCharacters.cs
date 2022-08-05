using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Characters {
    public class TestCharacters {
        
        public TestCharacters() {
            
        }

        public Character Create_Chad() {

            
            Character Chad = new() {
                Name = "Chad",
                Class = "Barbar",
                Level = "1",
                Race = "Chadd",
                Background = "From Chad",
                PlayerName = "ME",
                Alignment = "Chaad",
                Experince = "0",
                ProficiencyBonus = "1",
                Inspiration = "-1",
                JackOfAllTraides = true,
                ManaPool = "1000",
                SpentMana = "200",
                Strength = {
                    Value = "20",
                    SaveThrowProficiency = true,
                    Athletics = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Dexterity = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Acrobatics = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    SlightOfHand = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Stealth = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Constitution = {
                    Value = "10",
                    SaveThrowProficiency = true,

                },
                Intelligence = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Arcane = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    History = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Investigation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Nature = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Religion = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Wisdom = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Medicine = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    AnimalHandling = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Insight = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Survival = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Perception = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Charisma = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Performance = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Intimidation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Deception = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Persuation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Status = {
                    Armor = {
                        Value = "15",
                        Bonus = "0",
                    },
                    Initiative = "+3",
                    HealthPoints = {
                        Maximum = "20",
                        Current = "15",
                        Temporary = "5",
                    },
                    Exaustion = "1",
                    Darksight = true,
                    DarksightDistance = "18",
                    Speed = "9",
                    DeathSaves = {
                        Successes1 = true,
                        Successes2 = true,
                        Successes3 = true,
                        Failures1 = true,
                        Failures2 = true,
                        Failures3 = true,

                    }

                },
                Dice = {
                Dice = "1W20",
                Total = "1",
                Used = "2",
                },



            };
            Chad.WeaponList.Add(
                new Weapon() {
                    Weaponname = "Speer",
                    Bonus = "2",
                    _Attribute = WeaponAttributeEnum.Strenght,
                    Distance = "1,5m",
                    Proficiency = true,
                    Dice = "1w6"
                });
            Chad.WeaponList.Add(
                    new Weapon() {
                        Weaponname = "Schwert",
                        Bonus = "0",
                        _Attribute = WeaponAttributeEnum.Strenght,
                        Distance = "1,5m",
                        Proficiency = true,
                        Dice = "1w8"
                    });
            Chad.LimitedAbilityList.Add(
                new LimitedAbility() {
                    Name = "testability",
                    RestShort = true,

                    TotalUses = "5",
                    Used = "1"
                });
            Chad.SpellList.Add(
                new Spell() {
                    Name = "Fireball",
                    Description = "hihihuhu",
                    Reach = "30",
                    Dice = "ShitloadofDice",
                    RestLong = true,
                    RestShort = true,
                    Level = "3",
                    SpellUseLevel = "4"
                });
            Chad.ItemList.Add(new Item() {
                Name = "Schwert",
                StoragePlace = "Rucksack",
                Description = "gonnakillyou",
                Worth = "10",
                Count = "1",
                Weigth = "3",
            });

            return Chad;
        }
        public Character Create_Chad1() {
            Character Chad = new() {
                Name = "Chad1",
                Class = "Barbar",
                Level = "1",
                Race = "Chadd",
                Background = "From Chad",
                PlayerName = "ME",
                Alignment = "Chaad",
                Experince = "0",
                ProficiencyBonus = "1",
                Inspiration = "-1",
                JackOfAllTraides = true,
                ManaPool = "1000",
                SpentMana = "200",
                Strength = {
                    Value = "15",
                    SaveThrowProficiency = true,
                    Athletics = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Dexterity = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Acrobatics = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    SlightOfHand = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Stealth = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Constitution = {
                    Value = "10",
                    SaveThrowProficiency = true,

                },
                Intelligence = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Arcane = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    History = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Investigation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Nature = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Religion = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Wisdom = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Medicine = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    AnimalHandling = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Insight = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Survival = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Perception = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Charisma = {
                    Value = "10",
                    SaveThrowProficiency = true,
                    Performance = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Intimidation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Deception = {
                        Proficiency = true,
                        Expertice = true,
                    },
                    Persuation = {
                        Proficiency = true,
                        Expertice = true,
                    },
                },
                Status = {
                    Armor = {
                        Value = "15",
                        Bonus = "0",
                    },
                    Initiative = "+3",
                    HealthPoints = {
                        Maximum = "20",
                        Current = "15",
                        Temporary = "5",
                    },
                    Exaustion = "1",
                    Darksight = true,
                    DarksightDistance = "18",
                    Speed = "9",
                    DeathSaves = {
                        Successes1 = true,
                        Successes2 = true,
                        Successes3 = true,
                        Failures1 = true,
                        Failures2 = true,
                        Failures3 = true,
                    }
                },
                Dice = {
                Dice = "1W20",
                Total = "1",
                Used = "2",
                },
            };
            Chad.WeaponList.Add(
                new Weapon() {
                    Weaponname = "Speer",
                    Bonus = "2",
                    _Attribute = WeaponAttributeEnum.Strenght,
                    Distance = "1,5m",
                    Proficiency = true,
                    Dice = "1w6"
                });
            Chad.WeaponList.Add(
                    new Weapon() {
                        Weaponname = "Schwert",
                        Bonus = "0",
                        _Attribute = WeaponAttributeEnum.Strenght,
                        Distance = "1,5m",
                        Proficiency = true,
                        Dice = "1w8"
                    });

            return Chad;
        }
    }
}
