using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Controls;
using System.Globalization;

namespace SchedulerDateNavigatorCustomizationWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class ThemeNameConverterExtension : MarkupExtension, IValueConverter {
        static ThemeNameConverterExtension instance = new ThemeNameConverterExtension();
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return instance;
        }

        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            ListBoxItem listBoxItem = value as ListBoxItem;

            if (listBoxItem != null)
                return listBoxItem.Content;

            return value;
        }
        #endregion
    }
}