using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_07_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<String>() {"marron", "cian", "trullo"};
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String marron = "#804000", cian = "#00ffff", trullo = "#40c080";

            if (comboBox1.SelectedItem.ToString().Equals("marron"))
            {
                BackColor = ColorTranslator.FromHtml(marron);
            }else if (comboBox1.SelectedItem.ToString().Equals("cian"))
            {
                BackColor = ColorTranslator.FromHtml(cian);
            }
            else
            {
                BackColor = ColorTranslator.FromHtml(trullo);
            }
        }
    }
}