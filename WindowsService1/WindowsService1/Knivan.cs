﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using LogicNP.CryptoLogger;

namespace WindowsService1
{
    public partial class Knivan : ServiceBase
    {
        private Logger _logger = new Logger("TEST");

        public Knivan()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}