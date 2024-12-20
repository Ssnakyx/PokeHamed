﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.MVVM.View;

namespace WpfApp1.MVVM.ViewModel
{
    public class MainViewVM : BaseVM
    {

        public ICommand RequestChangeViewCommand { get; set; }
        public MainViewVM()
        {
           
            RequestChangeViewCommand = new RelayCommand(HandleRequestChangeViewCommand);
        }

        public void HandleRequestChangeViewCommand()
        {

        }
    }
}
