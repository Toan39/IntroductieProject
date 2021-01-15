﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disneyland
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatePickerInputForm disney = new DatePickerInputForm();
            disney.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RouteMapInputForm disney2 = new RouteMapInputForm();
            disney2.Show();
            this.Hide();
        }
    }
}
