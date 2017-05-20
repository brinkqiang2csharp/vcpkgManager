﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vcpkgManager.Common;

namespace vcpkgManager
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();

            SoftwareChecker.checkGit();
            SoftwareChecker.checkTargetVcpkg("F:\\working\\vcpkg_v2");
        }
    }
}
