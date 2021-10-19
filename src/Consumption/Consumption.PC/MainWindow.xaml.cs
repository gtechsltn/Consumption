﻿using Consumption.Shared.Common.Events;
using Consumption.ViewModel;
using Consumption.ViewModel.Common;
using Prism.Events;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Consumption.PC
{
    /// <summary>
    /// MaterialDesignMainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IEventAggregator aggregator)
        {
            InitializeComponent();
            aggregator.GetEvent<StringMessageEvent>().Subscribe(Execute);
            ListBoxMainManager.SelectionChanged += ListBoxMainManager_SelectionChanged;
        }

        private void ListBoxMainManager_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ListBoxMainManager.SelectedItem;
            if (item != null && item is Module m)
                (DataContext as MainViewModel).OpenPage(m.TypeName);
        }

        private void Execute(string arg)
        {
            switch (arg)
            {
                case "Min": this.WindowState = WindowState.Minimized; break;
                case "Max":
                    if (WindowState == WindowState.Normal)
                        this.WindowState = WindowState.Maximized;
                    else
                        this.WindowState = WindowState.Normal;
                    break;

                case "Exit": Environment.Exit(0); break;
            }
        }

        private void btnGithub(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples");
        }

        private void btnBilibili(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("https://space.bilibili.com/32497462");
        }

        private void btnQQ(object sender, RoutedEventArgs e)
        {
            Link.OpenInBrowser("http://qm.qq.com/cgi-bin/qm/qr?k=KpcFszjNfY2g-o0q1eEMIoYWbzjSMO2-&authKey=lg1kMENlcHkLO2gejRLvXmGq9Xy6GGb0X1h%2B9QDMhbNxvLLLugAsDQUIuzPJZhDy&group_code=874752819");
        }
    }
}