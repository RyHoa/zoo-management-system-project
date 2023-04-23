﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooManagementSystemControl;
using ZooManagementSystemEntity;

namespace ZooManagementSystemBoundary
{
    public partial class addTaskMenu : Form
    {
        public addTaskMenu()
        {
            InitializeComponent();
        }

        private void formAddTask_1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmpID_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // submit button
        // on click, check if any field is null, if none, then show green text. Otherwise, nothing.
        private void button1_Click(object sender, EventArgs e)
        {
            int errorCtrl = 0;
            foreach (ComboBox c in this.Controls)
            {
                ComboBox textBox = (ComboBox)c;

                if (textBox.Text == "" || c.SelectedItem == null)
                {
                    errorCtrl++;
                    MessageBox.Show("error");
                    break;
                }
                else { break; }
            }

            if (errorCtrl == 0)
            {
                MessageBox.Show("you've successfully submitted a task!");
                ReloadForm();
            }

        }

        private void ReloadForm()
        {
            comboAnID.ResetText();
            comboEmpID.ResetText();
            comboTaskType.ResetText();
            addTaskCal.SelectionStart = addTaskCal.MinDate;
        }

        private void comboEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // show logout page
            
            LogoutForm logoutform = new LogoutForm(); // create new logout page
            this.Close();             // close addtask page
            Application.Run(logoutform);        // run logout page
        }

        private void addTaskCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            // do nothing
        }

        private void btnSubmitTask_Click(object sender, EventArgs e)
        {

        }
    }
}