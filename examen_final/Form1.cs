using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace examen_final
{
    public partial class Form1 : Form
    {

        cls_negocios ObjetoEnt = new cls_negocios();
        public Form1()
        {
            InitializeComponent();
        }

        public void consultas()
        {
            ObjetoEnt.IdDireccion = int.Parse(textBox1.Text.Trim());
            dtgrid.DataSource = ObjetoEnt.GetDir();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultas();
        }
    }
}
