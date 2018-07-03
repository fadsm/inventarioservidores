﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddServer_Click(object sender, RoutedEventArgs e)
        {
            ServerAdd svrAdd = new ServerAdd();
            svrAdd.ShowDialog();
        }

        private void ServerSearch_Click(object sender, RoutedEventArgs e)
        {
            ViewServer viewSvr = new ViewServer();
            viewSvr.ShowDialog();
        }
    }
}
