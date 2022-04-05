﻿using System;
using System.Windows;

namespace Maelstrom.Infrastructure.Properties
{
    internal class WindowCloser
    {
        public static bool GetEnableWindowClosing(DependencyObject obj)
        {
            return (bool)obj.GetValue(EnableWindowClosingProperty);
        }

        public static void SetEnableWindowClosing(DependencyObject obj, bool value)
        {
            obj.SetValue(EnableWindowClosingProperty, value);
        }

        public static readonly DependencyProperty EnableWindowClosingProperty =
            DependencyProperty.RegisterAttached("EnableWindowClosing", typeof(bool), typeof(WindowCloser), new PropertyMetadata(false, OnEnableWindowClosingChanged));

        private static void OnEnableWindowClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Window window)
            {
                window.Loaded += (s, e) =>
                {
                    if (window.DataContext is IWindowCloser vm)
                    {
                        vm.Close += () =>
                        {
                            window.Close();
                        };
                        window.Closing += (s, e) =>
                        {
                            e.Cancel = !vm.CanClose;
                        };
                    }
                };
            }
        }
    }
}
