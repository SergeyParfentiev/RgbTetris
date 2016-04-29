﻿// Copyright 2016 Denis T (https://github.com/dragon-dreamer / dragondreamer [ @ ] live.com)
// SPDX-License-Identifier: GPL-3.0
using System;
using System.Windows.Data;
using System.Windows.Media;

namespace LedMatrixDebugConsole
{
    [ValueConversion(typeof(bool), typeof(ColorValue))]
    public class ButtonStatusToColorValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is bool))
                return null;

            return new ColorValue { Value = (bool)value ? Colors.Yellow : Colors.Black };
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
