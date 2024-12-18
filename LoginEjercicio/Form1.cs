using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.Connection.openConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de Form2
            Form2 form2 = new Form2();

            // Mostrar la ventana de Form2
            form2.Show(); // Usa ShowDialog() si quieres que sea modal

        }
    }
}
