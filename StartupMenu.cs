﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemEntity;
using ZooManagementSystemControl;

namespace ZooManagementSystemBoundary
{
    public partial class StartupMenu : Form
    {
   

        public StartupMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Close();
            loginform.Show();
        }
    }
}
