﻿using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anydesk
{
    public partial class BLogin : Form
    {
        public static api KeyAuthApp = new api(
            name: "NosClicker",
            ownerid: "DwmARF9jVd",
            secret: "34acda00ab12e7283ba47fbcc958bdf8fd7384083dc9e6a4d326dd4c16c96f61",
            version: "1.0"
        );
        public BLogin()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
            Application.ExitThread();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BRegister Nash = new BRegister();
            Nash.Show();
            base.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Console.Beep(500, 400);
            KeyAuthApp.login(user.Text, pass.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Login Success", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BMain emji = new BMain();
                emji.Show();
                this.Hide();
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void BLogin_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            KeyAuthApp.check();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
