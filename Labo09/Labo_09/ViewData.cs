using System;
using System.Windows.Forms;

namespace Labo_09
{
    public partial class ViewData : UserControl
    {
        public ViewData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios.");
            }
            else
            {

                try
                {
                    var dt = ConnectionDB.ExecuteQuery($"SELECT mat.idMateria, mat.nombre " +
                                                       "FROM INSCRIPCION ins, MATERIA mat, Estudiante est " +
                                                       $"WHERE ins.idMateria = mat.idMateria " +
                                                       $"AND ins.carnet = '{textBox1.Text}' " +
                                                       $" AND est.carnet = '00131819' ");

                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Datos obtenidos exitosamente.");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

            }
        }
    }
}