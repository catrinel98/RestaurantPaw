using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace yees
{
    public partial class Form2 : Form
    {
        ColectieComenzi colectie = new ColectieComenzi();
        Comenzi c;
        public Form2(ColectieComenzi c)
        {
            InitializeComponent();
            colectie = c;
            tbcomenzi.Text = c.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                sw.WriteLine(colectie.ToString());
                sw.Close();
                MessageBox.Show("Salvat cu succes!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 frm = new Form3(colectie);
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileStream, tbcomenzi.Text);
            fileStream.Close();
            MessageBox.Show("Serializare cu succes!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            tbcomenzi.Text = (string)bf.Deserialize(fileStream);

            tbcomenzi.Clear();
            tbcomenzi.Text += "Obiecte deserializate din fisier.dat" + Environment.NewLine;
            string result = "";
            foreach (Comenzi c in  colectie.Comenzi)
            {
                result += c.ToString() + Environment.NewLine;
            }
            tbcomenzi.Text += result;
            fileStream.Close();
            MessageBox.Show("Deserializare cu succes!");
        }

        private void btSalvare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog svd = new OpenFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(svd.FileName);
                tbcomenzi.Clear();
                tbcomenzi.Text += "Citit din fisierul" + svd.FileName + Environment.NewLine;
                tbcomenzi.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Citire cu succes!");
            }
        }
    }
}
