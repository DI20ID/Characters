using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Characters {
    public class UIControlFunktions {
        public MainWindow mainWindow = (MainWindow?)Application.Current.MainWindow;
        public UIControlFunktions() {
            
        }
        //Buttons
        public void BatchMinus_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            TextBox textBox = (TextBox)((DockPanel)((DockPanel)((Button)sender).Parent).Parent).Children[1];
            int.TryParse(textBox.Text, out int i);
            
            Popup popup = new Popup();
            TextBox popuptextbox = new();
            popuptextbox.HorizontalContentAlignment = HorizontalAlignment.Right;
            popuptextbox.Text = "1";
            popup.Child = popuptextbox;
            popup.PlacementTarget = button;
            popup.Placement = PlacementMode.Bottom;
            popup.MinWidth = button.ActualWidth;
            popup.IsOpen = true;
            popuptextbox.Focus();
            popuptextbox.SelectAll();
            popup.LostFocus += Popup_LostFocus;
            popup.KeyDown += Popup_KeyDown;
            void Popup_KeyDown(object sender, KeyEventArgs e) {
                if (e.Key == Key.Enter) {
                    int.TryParse(popuptextbox.Text, out int j);
                    if (i >= j) {
                        textBox.Text = (i - j).ToString();
                        ((Popup)sender).IsOpen = false;
                    }
                }
                if (e.Key == Key.Escape) {
                    ((Popup)sender).IsOpen = false;
                }
            }
            
        }
        public void BatchPlus_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            TextBox textBox = (TextBox)((DockPanel)((DockPanel)((Button)sender).Parent).Parent).Children[1];
            int.TryParse(textBox.Text, out int i);
            Popup popup = new Popup();
            TextBox popuptextbox = new();
            popuptextbox.HorizontalContentAlignment = HorizontalAlignment.Right;
            popuptextbox.Text = "1";
            popup.Child = popuptextbox;
            popup.PlacementTarget = button;
            popup.Placement = PlacementMode.Bottom;
            popup.MinWidth = button.ActualWidth;
            popup.IsOpen = true;
            popuptextbox.Focus();
            popuptextbox.SelectAll();
            popup.LostFocus += Popup_LostFocus;
            popup.KeyDown += Popup_KeyDown;
            void Popup_KeyDown(object sender, KeyEventArgs e) {
                if (e.Key == Key.Enter) {
                    int.TryParse(popuptextbox.Text, out int j);
                    textBox.Text = (i + j).ToString();
                    ((Popup)sender).IsOpen = false;
                }
                if (e.Key == Key.Escape) {
                    ((Popup)sender).IsOpen = false;
                }
            }
        }
        private void Popup_LostFocus(object sender, RoutedEventArgs e) {
            ((Popup)sender).IsOpen = false;
        }
        public void LoadButton_Click(object sender, RoutedEventArgs e) {
            if (((ListBox)mainWindow.lb_Characters).Items.Count > 0) { 
            string key = mainWindow.lb_Characters.SelectedItem!.ToString();
            mainWindow.Read_CharacterDictionary_From_File(key);
        }
        }
        public void SaveButton_Click(object sender, RoutedEventArgs e) {
            mainWindow.Copy_Local_Lists_To_Character();
            if(mainWindow.CharacterKey == null)
                mainWindow.No_Character_Key_Dialog();
            else
            mainWindow.Write_CharacterDictionary_To_File();
        }
        public void SaveAssButton_Click(object sender, RoutedEventArgs e) {

            mainWindow.Copy_Local_Lists_To_Character();
            mainWindow.No_Character_Key_Dialog();
        }
        public void Expander_Click(object sender, RoutedEventArgs e) {
            DockPanel dockPanel = (DockPanel)((DockPanel)((Button)sender).Parent).Children[1];
            TextBlock textBlock = (TextBlock)((DockPanel)((DockPanel)((Button)sender).Content).Children[0]).Children[0];
            
            
            if (dockPanel.Visibility == Visibility.Collapsed)
                dockPanel.Visibility = Visibility.Visible;
            else if (dockPanel.Visibility == Visibility.Visible)
                dockPanel.Visibility = Visibility.Collapsed;
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            Debug.Print(mainWindow.SpellList.ToString());
        }
        public void Minus_Click(object sender, RoutedEventArgs e) {
            TextBox textBox = (TextBox)((DockPanel)((DockPanel)((Button)sender).Parent).Parent).Children[1];
            int.TryParse(textBox.Text, out int result);
            if (result > 0) {
                int i = result - 1;
                textBox.Text = i.ToString();
            }
        }
        public void Plus_Click(object sender, RoutedEventArgs e) {
            TextBox textBox = (TextBox)((DockPanel)((DockPanel)((Button)sender).Parent).Parent).Children[1];
            int.TryParse(textBox.Text, out int result);
            int i = result + 1;
            textBox.Text = i.ToString();
        }
        public void CastButton_Click(object sender, RoutedEventArgs e) {
           
            int spellCost = int.Parse(((Spell)mainWindow.SpellGrid.SelectedItem).SpellUseLevel);
            int usedMana = int.Parse(mainWindow.Character.SpentMana);
            mainWindow.Character.SpentMana = (usedMana + spellCost).ToString();
        }
        public void Button_Up_Click(object sender, RoutedEventArgs e) {
            
            switch (((Button)sender).Tag) {
                case "G":
                    int.TryParse(mainWindow.Character.Gold, out int i);
                    int.TryParse(mainWindow.Character.Platin, out int j);
                    if (i >= 10) {
                        i -= 10;
                        j += 1;
                        mainWindow.Character.Gold = i.ToString();
                        mainWindow.Character.Platin = j.ToString();
                    }
                    break;
                case "E":
                    int.TryParse(mainWindow.Character.Electrum, out int k);
                    int.TryParse(mainWindow.Character.Gold, out int l);
                    if (k >= 2) {
                        k -= 2;
                        l += 1;
                        mainWindow.Character.Electrum = k.ToString();
                        mainWindow.Character.Gold = l.ToString();
                    }
                    break;
                case "S":
                    int.TryParse(mainWindow.Character.Silver, out int m);
                    int.TryParse(mainWindow.Character.Electrum, out int n);
                    if (m >= 5) {
                        m -= 5;
                        n += 1;
                        mainWindow.Character.Silver = m.ToString();
                        mainWindow.Character.Electrum = n.ToString();
                    }
                    break;
                case "C":
                    int.TryParse(mainWindow.Character.Copper, out int o);
                    int.TryParse(mainWindow.Character.Silver, out int p);
                    if (o >= 10) {
                        o -= 10;
                        p += 1;
                        mainWindow.Character.Copper = o.ToString();
                        mainWindow.Character.Silver = p.ToString();
                    }
                    break;
            }
        }
        public void Button_Down_Click(object sender, RoutedEventArgs e) {

            switch (((Button)sender).Tag) {
                case "P":
                    int.TryParse(mainWindow.Character.Gold, out int o);
                    int.TryParse(mainWindow.Character.Platin, out int p);
                    if (p >= 1) {
                        o += 10;
                        p -= 1;
                        mainWindow.Character.Gold = o.ToString();
                        mainWindow.Character.Platin = p.ToString();
                    }
                    break;
                case "G":
                    int.TryParse(mainWindow.Character.Electrum, out int i);
                    int.TryParse(mainWindow.Character.Gold, out int j);
                    if (j >= 1) {
                        i += 2;
                        j -= 1;
                        mainWindow.Character.Electrum = i.ToString();
                        mainWindow.Character.Gold = j.ToString();
                    }
                    break;
                case "E":
                    int.TryParse(mainWindow.Character.Silver, out int m);
                    int.TryParse(mainWindow.Character.Electrum, out int n);
                    if (n >= 1) {
                        m += 5;
                        n -= 1;
                        mainWindow.Character.Silver = m.ToString();
                        mainWindow.Character.Electrum = n.ToString();
                    }
                    break;
                case "S":
                    int.TryParse(mainWindow.Character.Copper, out int k);
                    int.TryParse(mainWindow.Character.Silver, out int l);
                    if (l >= 1) {
                        k += 10;
                        l -= 1;
                        mainWindow.Character.Copper = k.ToString();
                        mainWindow.Character.Silver = l.ToString();
                    }
                    break;
            }
        }
        public void Textbox_with_Tooltip_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e) {
            TextBox textBox = (TextBox)sender;
            ((ToolTip)textBox.ToolTip).Content = textBox.Text;
            if ((bool)e.NewValue == true) {

                ((ToolTip)textBox.ToolTip).IsOpen = true;
            }
            else
                ((ToolTip)textBox.ToolTip).IsOpen = false;
        }

    }
}
