﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Laba_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void transformationsButton_Click(object sender, EventArgs e)
        {
            Transformations transformationsForm = new Transformations();
            transformationsForm.Show();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Ping_Pong ping_Pong = new Ping_Pong();
            ping_Pong.Show();
        }
    }
}