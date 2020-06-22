using System;
using System.Globalization;
using System.Windows.Data;

namespace LeagueOfLegendsLogin.Converters
{
    class UnixToTimeConverter : IValueConverter
    {
        DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is long v && targetType == typeof(string))
            {
                return epoch.AddMilliseconds(v);
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
