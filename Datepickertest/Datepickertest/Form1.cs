using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datepickertest
{
    public partial class Form1 : Form
    {
		List<datum> datumlist = new List<datum>();
		int selectedmonth = 3; //waarden door gebruiker gekozen
		int selectedyear = 2021; //waarden door gebruiker gekozen
		public Form1()
        {
            InitializeComponent();
			RegenData();
        }

		public void RegenData()
		{
			int t = 0;
			Random random = new Random();
			while (t <= DateTime.DaysInMonth(selectedyear, selectedmonth))
			{
				DateTime today = DateTime.Now;
				var date = today.Date;
				datumlist.Add(new datum());
				datumlist[t].rij = t;
				datumlist[t].date = date.ToString((datumlist[t].rij + 1) + " " + selectedmonth.ToString() + " " + selectedyear.ToString());			
				datumlist[t].neerslag = random.Next(0, 100);		//neerslag is random getal tussen 0 en 100
				t++;
			}
			//de list wordt gesorteerd op neerslag
			datumlist = datumlist.OrderBy(x => x.neerslag).ToList();

			//print de hele list, gesorteerd.
			int i = 0;
			foreach (datum rij in datumlist)
			{
				label1.Text = label1.Text + "tabelrij" + datumlist[i].rij + "        " + datumlist[i].date + "         Neerslag: " + datumlist[i].neerslag + "\n";
				i++;
			}

			//print beste dag
			label1.Text = label1.Text + "\n" + "beste dag: " + "\n" + datumlist[0].date + "         Neerslag: " + datumlist[0].neerslag;

			//print alle dagen onder 20 neerslag
			int j = 1;
			foreach (datum rij in datumlist)
			{
				if (((datumlist[j].neerslag) < 20) && datumlist[j].neerslag != datumlist[0].neerslag)
				{	
					label1.Text = label1.Text + "\n" + "andere geschikte dag: " + "\n" + datumlist[j].date + "         Neerslag: " + datumlist[j].neerslag;
					j++;
				}
			}
		}

        
    }

    internal class datum
	{
		public int rij;
		public string date;
		public int neerslag;
	}
}


