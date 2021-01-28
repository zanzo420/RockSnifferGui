﻿using RockSnifferGui.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RockSnifferGui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private GameProcessService gameProcessService;

        public App()
        {
            this.gameProcessService = new GameProcessService();
            this.Exit += App_Exit;
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            if(this.gameProcessService != null)
            {
                this.gameProcessService.Shutdown();
            }
        }
    }
}
