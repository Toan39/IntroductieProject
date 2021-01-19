using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Disneyland
{
    public partial class progressbar : Form
    {
        public progressbar()
        {
            InitializeComponent();
            //kees();
        }

        private void progressbar_Load(object sender, EventArgs e)
        {

        }

        /* public void kees()
         {
             for(int t = 0; t < 1000; t++)
             {
                 progressBar1.Value = progressBar1.Value + 1;
                 Thread.Sleep(1);
             }
         }*/
    }
}


  
