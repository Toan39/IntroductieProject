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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 map = new Form5();
            map.Show();
            this.Hide();
        }

        private void btnGetItem_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox.CheckedItems)
                listBoxItem.Items.Add(s);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
