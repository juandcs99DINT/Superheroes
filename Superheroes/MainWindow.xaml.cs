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

namespace Superheroes
{
    public partial class MainWindow : Window
    {
        readonly MainWindowVM mainWindowVM = new MainWindowVM();
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainWindowVM;
        }

        private void SiguienteImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            mainWindowVM.Avanzar();
        }

        private void AnteriorImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            mainWindowVM.Retroceder();
        }
    }
}
