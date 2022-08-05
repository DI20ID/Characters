using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Characters {
    public class Setup {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        UIControlFunktions uif = new();
        public Setup() {

            if (!Directory.Exists(mainWindow.Resourcefolder)) {
                Directory.CreateDirectory(mainWindow.Resourcefolder);
            }

            if (SystemParameters.FullPrimaryScreenHeight < 1200) {
                mainWindow.MainScrollView.Height = SystemParameters.FullPrimaryScreenHeight - 50;
            }
            Application.Current.MainWindow.Left = 0;
            Application.Current.MainWindow.Top = 0;

            mainWindow.ExpanderButton.Click += uif.Expander_Click;
            mainWindow.SaveButton.Click += uif.SaveButton_Click;
            mainWindow.SaveAssButton.Click += uif.SaveAssButton_Click;
            mainWindow.LoadButton.Click += uif.LoadButton_Click;
            mainWindow.ItemList.ListChanged += ItemList_ListChanged;
            
        }

        private void ItemList_ListChanged(object? sender, System.ComponentModel.ListChangedEventArgs e) {
            double d = 0;
            double uf = 2.2046;
            foreach (Item item in mainWindow.ItemList) {
                if (double.TryParse(item.Weigth, NumberStyles.Any, CultureInfo.InvariantCulture, out double de))
                    
                if (double.TryParse(item.Count, NumberStyles.Any, CultureInfo.InvariantCulture, out double f))
                    d += de * f;
            }
            d = Math.Round(d, 2);
            mainWindow.tbl_weightinpound.Text = d.ToString();
            mainWindow.tbl_weigthcharacterwithinventory.Text = (d + int.Parse(mainWindow.Character.Weigth!)).ToString();
            double r = Math.Round(d / uf, 2);
            mainWindow.tbl_weightinkg.Text = r.ToString();
            d = 0;
            foreach (Item item in mainWindow.ItemList) {
                if (double.TryParse(item.Worth, NumberStyles.Any, CultureInfo.InvariantCulture, out double de))
                    d = d + de;
            }
            d = Math.Round(d, 2);
            mainWindow.tbl_inventoryworth.Text = d.ToString();
            
            

        }
    }
}
