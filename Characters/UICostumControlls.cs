using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace Characters {

    public class ExpanderButton : Button {
        UIControlFunktions uIControlFunktions;
        public ExpanderButton() {

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            FocusVisualStyle = null;
        }
    }
    public class Button_Minus : Button {
        UIControlFunktions uIControlFunktions;
        public Button_Minus() {
           
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            uIControlFunktions = new();
            ToolTip toolTip = new ToolTip();
            toolTip.Content = this.Content;
            this.ToolTip = toolTip;
            this.Click += uIControlFunktions.Minus_Click;
            this.MouseRightButtonUp += uIControlFunktions.BatchMinus_Click;
        }
    }
    public class Textbox_with_Tooltip : TextBox {
        UIControlFunktions uIControlFunktions = new();
        public Textbox_with_Tooltip() {

            MainWindow window = (MainWindow)Application.Current.MainWindow;
            
            ToolTip toolTip = new ToolTip();
            this .ToolTip = toolTip;
            IsMouseDirectlyOverChanged += uIControlFunktions.Textbox_with_Tooltip_IsMouseDirectlyOverChanged;
        }



    }
    public class Button_Plus : Button {
        UIControlFunktions uIControlFunktions;
        public Button_Plus() {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            uIControlFunktions = new();
            this.Click += uIControlFunktions.Plus_Click;
            this.MouseRightButtonUp += uIControlFunktions.BatchPlus_Click;
        }
    }
    public class Button_Up : Button {
        UIControlFunktions uIControlFunktions;
       
        public Button_Up() {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            
            uIControlFunktions = new();
            this.Click += uIControlFunktions.Button_Up_Click; ;
         //   this.MouseRightButtonUp += uIControlFunktions.BatchPlus_Click;
        }

       
    }
    public class Button_Down : Button {
        UIControlFunktions uIControlFunktions;
        public Button_Down() {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            uIControlFunktions = new();
            this.Click += uIControlFunktions.Button_Down_Click;
         //   this.MouseRightButtonUp += uIControlFunktions.BatchPlus_Click;
        }
    }
    public class DataGridNumericColumn : DataGridTextColumn {
        
        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs) {
            TextBox? edit = editingElement as TextBox;
            edit!.PreviewTextInput += OnPreviewTextInput;


            return base.PrepareCellForEdit(editingElement, editingEventArgs);
        }
        void OnPreviewTextInput(object sender, TextCompositionEventArgs e) {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static bool IsTextAllowed(string text) {
            return new Regex("^[0-9]$").IsMatch(text);
        }
        
    }
    public class DataGridDecimalColumn : DataGridTextColumn {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        protected override bool CommitCellEdit(FrameworkElement editingElement) {
            TextBox? edit = editingElement as TextBox;
            edit!.LostKeyboardFocus += DataGridDecimalColumn_LostKeyboardFocus; ;
       
            return base.CommitCellEdit(editingElement);
        }

        private void DataGridDecimalColumn_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) {
            e.Handled = !IsCompositTextAllowed(((TextBox)sender).Text);
            if(e.Handled == true) {
                ((TextBox)sender).Text = "";
            }
           
        }
        private static bool IsCompositTextAllowed(string text) {
            return new Regex("^\\d*(\\.\\d*)?$").IsMatch(text);
        }

        protected override object PrepareCellForEdit(FrameworkElement editingElement, RoutedEventArgs editingEventArgs) {
            TextBox? edit = editingElement as TextBox;
            edit!.PreviewTextInput += OnPreviewTextInput;
            
            return base.PrepareCellForEdit(editingElement, editingEventArgs);
        }
        void OnPreviewTextInput(object sender, TextCompositionEventArgs e) {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static bool IsTextAllowed(string text) {
            return new Regex("^[0-9\\.\\,]$").IsMatch(text);
        }

    }
    public class NumericTextbox : TextBox {
        public NumericTextbox() {
            this.PreviewTextInput += OnPreviewTextInput;
            
        }
       
        void OnPreviewTextInput(object sender, TextCompositionEventArgs e) {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static bool IsTextAllowed(string text) {
            return !new Regex("[^0-9.]+").IsMatch(text);
        }
    }
    public class CastButton : Button {
        UIControlFunktions uIControlFunktions;
        public CastButton() {
            uIControlFunktions = new();
            Content = "Zaubern";
            Click += uIControlFunktions.CastButton_Click; 

        }

        
    }

    public class ToggleButtonDockpanel : DockPanel {
        public ToggleButtonDockpanel() {

            this.Children.Add(new ToggleButton() { Content = "0", Padding = new Thickness(5, 0, 5, 0) });
            this.Children.Add(new ToggleButton() { Content = "1", Padding = new Thickness(5, 0, 5, 0) });
            this.Children.Add(new ToggleButton() { Content = "2", Padding = new Thickness(5, 0, 5, 0) });
            this.Children.Add(new ToggleButton() { Content = "3", Padding = new Thickness(5, 0, 5, 0) });
            this.Children.Add(new ToggleButton() { Content = "4", Padding = new Thickness(5, 0, 5, 0) });
            this.Children.Add(new ToggleButton() { Content = "5", Padding = new Thickness(5, 0, 5, 0) });

            foreach (ToggleButton toggleButton in this.Children) {
                {
                    toggleButton.SetBinding(ToggleButton.IsEnabledProperty, new MultiBinding() {
                        Bindings = { 
                            new Binding("Level") {  },
                            new Binding(){Source = toggleButton, Path = new PropertyPath("Content") } },
                        Converter = new SpellUseLevelConvert()
                    });

                    toggleButton.SetBinding(ToggleButton.IsCheckedProperty, new MultiBinding() {
                        Bindings = {
                            new Binding("SpellUseLevel") { },
                            new Binding(){Source = toggleButton, Path = new PropertyPath("Content") } },
                        Converter = new SpellUseLevelConvert2()
                    });
                    toggleButton.Checked += RadioButtonDockpanel_Checked;
                }
            }
        }

        private void RadioButtonDockpanel_Checked(object sender, RoutedEventArgs e) {
            ToggleButton radioButton = (ToggleButton)sender;
            NumericTextbox textBlock = (NumericTextbox)(((DockPanel)((DockPanel)((ToggleButton)sender).Parent).Parent).Children[1]);
            textBlock.Text = radioButton.Content.ToString();
        }
    }
}
