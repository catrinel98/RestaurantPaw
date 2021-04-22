using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yees
{
    public partial class Form3 : Form
    {
        ColectieComenzi colectie = new ColectieComenzi();
        public Form3(ColectieComenzi c)
        {
            InitializeComponent();
            colectie = c;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void button1populare_Click(object sender, EventArgs e)
        {
            foreach (Comenzi c in colectie.Comenzi)
            {
                ListViewItem itm = new ListViewItem(c.Pret.ToString());
                itm.SubItems.Add(c.Numeclient);
                itm.SubItems.Add(c.Cantitate.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.Remove();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
