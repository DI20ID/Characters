using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Characters {
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public string Key = "";
        public MainWindow window1;
        public Window1(MainWindow window) {
            InitializeComponent();
            this.window1 = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            window1.CharacterKey = _Key.Text;
            DialogResult = true;
        }
    }
}
