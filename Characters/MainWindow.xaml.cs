using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Characters {
    public class ConstitutionAttribute : Attribute { }

    public class CharacterDictionaryClass : Dictionary<string, Character>{
        
    }
    public enum WeaponAttributeEnum { _ = 0, Strenght = 1, Dexterity = 2, Constitution = 3, Intelligence = 4, Wisdom = 5, Charisma = 6 };

    public partial class MainWindow : Window {
        public readonly string Resourcefolder = "Resources";
        public string CharacterKey;

        public TestCharacters Test = new();
        //public CharacterDictionaryClass CharacterDictionary = new ();
        public BindingList<string> CharacterKeysList = new();
        public Character Character = new();

        public BindingList<Weapon> WeaponList = new();
        public BindingList<LimitedAbility> LimitedAbilityList = new();
        public BindingList<Spell> SpellList = new();
        public BindingList<Item> ItemList = new();
        // UIElement[] AttributeBonusLabels;
        // UIElement[] SaveThrowTextBlocks;
       
       
       
        
        public MainWindow() {
            
            UIControlFunktions uif = new();
            

            InitializeComponent();

            lb_Characters.ItemsSource = CharacterKeysList;
            lb_Characters.DataContext = CharacterKeysList;

            new Setup();
            new Bindings();
            Get_Character_Key_List();
           // Fill_Listbox();
            
        }
        public void Get_Character_Key_List() {
            IEnumerable<string> list = new List<string>();
            list = Directory.EnumerateFiles(Resourcefolder);
            foreach (string s in list)
                CharacterKeysList.Add(s.Substring(10).Replace(".json", ""));
        }

        private void Fill_Listbox() {
            
         }



      //  public void Change_Character(string Key) {
      //      Character.ChangeTo(CharacterDictionary[Key]);
      //      Copy_Character_Lists_To_Local();
      //  }

       

        public void No_Character_Key_Dialog() {
            Window w = new Window1(this);
            w.DataContext = this.DataContext;
            w.ShowDialog();
            
            if (w.DialogResult == true) {
                //Add_Character_To_Dictionary();
                Write_CharacterDictionary_To_File();
                CharacterKeysList.Add(CharacterKey);
            }
            this.Title = CharacterKey;
        }

       // private void Overwrite_Character_in_Dictionary() {
       //     if(CharacterDictionary.ContainsKey(Character.Key)) {
       //         CharacterDictionary[Character.Key] = Character;
       //     }
       // }
       // private void Add_Character_To_Dictionary() {
       //     CharacterDictionary.Add(Character.Key, Character);
       // }
        public void Write_CharacterDictionary_To_File() {
            using FileStream createStream = File.Create((Resourcefolder + "\\" + CharacterKey + ".json"));
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(Character, options);
            JsonSerializer.Serialize(createStream, Character, options);
            createStream.Dispose();
        }
        public void Read_CharacterDictionary_From_File(string Key) {
            string jsonfile = Resourcefolder + "\\" + Key + ".json";
            string jsonString = File.ReadAllText(jsonfile);
            Character character = JsonSerializer.Deserialize<Character>(jsonString);
            Character.ChangeTo(character);
            Copy_Character_Lists_To_Local();
            CharacterKey = Key;
            this.Title = CharacterKey;
        }





        public void Copy_Local_Lists_To_Character() {
            Character.WeaponList.Clear();
            foreach (Weapon i in WeaponList) {
                Character.WeaponList.Add(i);
            }
            Character.LimitedAbilityList.Clear();
            foreach (LimitedAbility i in LimitedAbilityList) {
                Character.LimitedAbilityList.Add(i);
            }
            Character.SpellList.Clear();
            foreach (Spell i in SpellList) {
                Character.SpellList.Add(i);
            }
            Character.ItemList.Clear();
            foreach (Item i in ItemList) {
                Character.ItemList.Add(i);
            }
        }
        private void Copy_Character_Lists_To_Local() {
            WeaponList.Clear();
            foreach (Weapon i in Character.WeaponList) {
                WeaponList.Add(i);
            }
            LimitedAbilityList.Clear();
            foreach (LimitedAbility i in Character.LimitedAbilityList) {
                LimitedAbilityList.Add(i);
            }
            SpellList.Clear();
            foreach (Spell i in Character.SpellList) {
                SpellList.Add(i);
            }
            ItemList.Clear();
            foreach (Item i in Character.ItemList) {
                ItemList.Add(i);
            }
        }




        
    }
}
