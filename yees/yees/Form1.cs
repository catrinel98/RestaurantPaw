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
    public partial class Form1 : Form
    {
        ColectieComenzi comenzi = new ColectieComenzi();
        public Form1()
        {
            InitializeComponent();



        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (tbpret.Text == "")
                errorProvider1.SetError(tbpret, "Introduceti cifre aferente codului!");
            if (tbcantitate.Text == "")
                errorProvider2.SetError(tbcantitate, "Introduceti cifre aferente codului!");

            try
            {
                int pret = Convert.ToInt32(tbpret.Text);
                string nume = tbnc.Text;
                int cantitate = Convert.ToInt32(tbcantitate.Text);
                Comenzi c = new Comenzi(pret, cantitate, nume);
                comenzi += c;
                MessageBox.Show(c.ToString());
                

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Introdu valorile corect!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally

            {

                tbpret.Clear();
                tbnc.Text = "";
                tbcantitate.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(comenzi);

            frm.Show();
        }

        private void tbpret_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
