using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace Characters {
    //----------------------------------------------ConverterTemplates-----------------------------------------------------------------------
    public class MultiConverter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();

        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
    public class Converter : IValueConverter {
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
    //---------------------------------------------Converters------------------------------------------------------------------------------------------
    public class Converters : MultiConverter, IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            if (values[0] == null || (string)values[0] == "") values[0] = "0";
            if (values[1] == null || (string)values[1] == "") values[1] = "0";
            decimal v = int.Parse((string)values[0]);
            decimal v1 = int.Parse((string)values[1]);
            v = Math.Floor((v - 10) / 2);
            if ((bool)values[3] == true) {
                v += v1;
                if ((bool)values[4])
                    v += v1;
            }
            else if ((bool)values[2] == true)
                v += Math.Floor(v1 / 2);
            string r;
            if (v >= 0) r = "+" + v.ToString();
            else r = v.ToString();
            return r;
        }
    }
    public class AttributeBonusConvert : Converter, IValueConverter {
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null || (string)value == "") value = "0";
            decimal v = int.Parse((string)value);
            v = Math.Floor((v - 10) / 2);
            string r;
            if (v >= 0) r = "+" + v.ToString();
            else r = v.ToString();
            return r;
        }
    }
    public partial class SpellUseLevelConvert : MultiConverter, IMultiValueConverter {
        public object Convert(object[]? values, Type targetType, object parameter, CultureInfo culture) {
            int v = 0;
            if (values[0] != DependencyProperty.UnsetValue) {
                if (values[0] == null || (string)values[0] == "") values[0] = "0";
                v = int.Parse((string)values[0]);
            }
            if (values[1] != DependencyProperty.UnsetValue) {
                if (values[1] == null || (string)values[1] == "") values[1] = "0";
                int w = int.Parse((string)values[1]);
                if (v > w)
                    return false;
                else
                    return true;
            }
            return false;
        }
    }
    public class SpellUseLevelConvert1 : MultiConverter, IMultiValueConverter {
        public object Convert(object[]? values, Type targetType, object parameter, CultureInfo culture) {
            string s = "";
            for (int i = 0; i <= 5; i++) {
                if ((bool)values[i] == true)
                    s = i.ToString();

            }
            return s;
        }
    }
    public class SpellUseLevelConvert2 : MultiConverter, IMultiValueConverter {
        public object Convert(object[]? values, Type targetType, object parameter, CultureInfo culture) {
            int v = 0;
            if (values[0] != DependencyProperty.UnsetValue) {
                if (values[0] == null || (string)values[0] == "") values[0] = "0";
                v = int.Parse((string)values[0]);

            }
            if (values[1] != DependencyProperty.UnsetValue) {
                if (values[1] == null || (string)values[1] == "") values[1] = "0";
                int w = int.Parse((string)values[1]);
                if (v == w)
                    return true;
                else
                    return false;
            }

            return 0;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            return new object[] { "1" };
        }
    }
    public class InventoryWeightConvert : Converter, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            decimal d = 0;
            foreach (Item item in mainWindow.ItemList) {
                if (decimal.TryParse(item.Weigth, out decimal de))
                    d = d + de;
            }
            return d;
        }
    }
    public class burdendConverter : Converter, IValueConverter {
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {
            int i = 0;
            if (value != DependencyProperty.UnsetValue) {

                if (value == null || (string)value == "") value = "0";
                i = int.Parse(value.ToString()) * 15 + 1;
            }
            return i;
        }
    }
    public class heavilyburdendConverter : Converter, IValueConverter {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {

            int i = 0;
            if (value != DependencyProperty.UnsetValue) {

                if (value == null || (string)value == "") value = "0";
                i = int.Parse(value.ToString()) * 30;
            }
            double d = 0;
            double uf = 2.2046;
            foreach (Item item in mainWindow.ItemList) {
                if (double.TryParse(item.Weigth, NumberStyles.Any, CultureInfo.InvariantCulture, out double de))
                    d = d + de;
            }
            d = Math.Round(d, 2);
            double j = d + 1;
            return j;
        }
    }
    public class characterwithinvenoryweight : Converter, IValueConverter {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {
            int i = 0;
            if (value != DependencyProperty.UnsetValue) {

                if (value == null || (string)value == "") value = "0";
                i = int.Parse(value.ToString());
            }
            double d = 0;
            foreach (Item item in mainWindow.ItemList) {
                if (double.TryParse(item.Weigth, NumberStyles.Any, CultureInfo.InvariantCulture, out double de))
                    d = d + de;
            }
            d = Math.Round(d, 2);
            double j = d + i;

            return j.ToString();
        }
    }
    public class JackofallTraidesConvert : Converter, IValueConverter {
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null || (string)value == "") value = "0";
            decimal v = int.Parse((string)value);
            v = Math.Floor(v / 2);
            string r;
            if (v >= 0) r = "+" + v.ToString();
            else r = v.ToString();
            return r;
        }
    }
    public class SaveThrowProficiencyConvert : MultiConverter, IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            if (values[0] == null || (string)values[0] == "") values[0] = "0";
            if (values[1] == null || (string)values[1] == "") values[1] = "0";
            decimal v = int.Parse((string)values[0]);
            decimal v1 = int.Parse((string)values[1]);
            v = Math.Floor((v - 10) / 2);
            if ((bool)values[2])
                v += v1;

            string r;
            if (v >= 0) r = "+" + v.ToString();
            else r = v.ToString();
            return r;
        }
    }
    public class WeaponAttackConvert : MultiConverter, IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {

            decimal v =0;
            string r = "";
            if (values[1] != DependencyProperty.UnsetValue)
                r = (string)values[1];
            if (values[0] != DependencyProperty.UnsetValue) {
                if (values[0] == null || (string)values[0] == "") values[0] = "0";
                r = (string)values[1];
                 v = int.Parse((string)values[0]);

                if ((bool)values[2] == true)
                    v += int.Parse((string)values[3]);
                

            }
            if (values[4] != DependencyProperty.UnsetValue && values[5] != DependencyProperty.UnsetValue && 
                values[6] != DependencyProperty.UnsetValue) {

                switch (values[4]) {
                    case WeaponAttributeEnum.Strenght:
                        decimal.TryParse((string)values[5], out decimal i);

                        i = Math.Floor((i - 10) / 2);
                        v += i;
                        break;
                    case WeaponAttributeEnum.Dexterity:
                        decimal.TryParse((string)values[5], out decimal j);
                        i = Math.Floor((j - 10) / 2);
                        v += i;
                        break;
                }
            }
            if (v > 0)
                r = r + "+" + v.ToString();
            return r;
        }
    }
    public class WeaponDamageConvert : MultiConverter, IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            decimal v = 0;
            string r = "";
            if (values[1] != DependencyProperty.UnsetValue)
                r = (string)values[1];
            if (values[0] != DependencyProperty.UnsetValue) {
                if (values[0] == null || (string)values[0] == "") values[0] = "0";
                r = (string)values[1];
                v = int.Parse((string)values[0]);
                if (v > 0)
                    r = r + "+" + v.ToString();
            }
            if (values[2] != DependencyProperty.UnsetValue && values[3] != DependencyProperty.UnsetValue && 
                values[4] != DependencyProperty.UnsetValue) {

                switch (values[2]) {
                    case WeaponAttributeEnum.Strenght:
                        decimal.TryParse((string)values[3], out decimal i);

                        i = Math.Floor((i - 10) / 2);
                        v += i;
                        break;
                    case WeaponAttributeEnum.Dexterity:
                        decimal.TryParse((string)values[4], out decimal j);
                        i = Math.Floor((j - 10) / 2);
                        v += i;
                        break;
                }
            }
            if (v > 0)
                r = r + "+" + v.ToString();
            return r;
        }
    }
}
