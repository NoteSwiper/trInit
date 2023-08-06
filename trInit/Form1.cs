﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trInit {
    public partial class Form1 : Form {
        private readonly Assembly ExecAssembly = Assembly.GetExecutingAssembly();
        public Form1() {
            InitializeComponent();
        }

        private void MenuItemHelpAbout_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "Window - " + ExecAssembly.GetName();
        }
    }
}
