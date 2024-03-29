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
using TexodeTaskWin.Service;
using TexodeTaskWin.ViewModel;

namespace TexodeTaskWin.View
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Page
    {
        public UpdatePage(ICardService cardService, MainWindow mainWindow, int id)
        {
            InitializeComponent();

            DataContext = new UpdatePageViewModel(cardService, mainWindow, id);
        }
    }
}
