﻿using System;
using System.Windows.Forms;

namespace Labo_09
{
    public partial class RegisterStudent : UserControl
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("no se pueden  dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonquery($"INSERT INTO ESTUDIANTE VALUES(" +
                                                 $" '{textBox3.Text}',"  +
                                                 $" '{textBox1.Text}' ," +
                                                 $" '{textBox2.Text}' ," +
                                                 $"{textBox4.Text})");

                    MessageBox.Show("Se ha registrado el estudiante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                    throw;
                }
            }
        }
    }
}