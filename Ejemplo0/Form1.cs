using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi primer programa en visual studio ");
        }

        private void Validacion_Click(object sender, EventArgs e)
        {
            Validacion();
        }

        private void Validacion()
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Campo vacio 1");
               
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Campo vacio 2");
                
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Campo vacio 3");
                
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Campo vacio 4");
                
            }
        }
    }
}
