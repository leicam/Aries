﻿using Aries.WPF.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Aries.WPF
{
    public partial class App : Application
    {
        private void StartupApplication(object sender, StartupEventArgs e)
            => Program.Main();
    }
}