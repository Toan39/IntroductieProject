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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 home = new Form2();
            home.Show();
            this.Hide();
        }
       /* private void datePicker()
        {
            label2.Text = 
        }*/

    }
}
