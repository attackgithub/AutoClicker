﻿using System.Windows;
using System.Windows.Threading;

namespace AutoClicker
{
    public partial class App
    {
        public App()
        {
            DispatcherUnhandledException += OnDispatcherUnhandledException;
        }

        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs arg)
        {
            MessageBox.Show(arg.Exception.ToString(), "Something bad was happened");
            arg.Handled = true;
        }
    }
}