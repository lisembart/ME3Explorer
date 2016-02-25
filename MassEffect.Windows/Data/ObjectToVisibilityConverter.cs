﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MassEffect.Windows.Data
{
	public class ObjectToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value == null ? Visibility.Collapsed : Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
