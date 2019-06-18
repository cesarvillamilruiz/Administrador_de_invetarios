using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda
{
    public partial class Form1 : Form
    {
        conexion c = new conexion();
        
        public Form1()
        {
            
            InitializeComponent();
            smallPanel.Height = btnRegistrar.Height;
            smallPanel.Top = btnRegistrar.Top;
            registrar1.BringToFront();

        }

       

        private void consultar1_Load(object sender, EventArgs e)
        {


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            smallPanel.Height = btnRegistrar.Height;
            smallPanel.Top = btnRegistrar.Top;
            registrar1.BringToFront();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            smallPanel.Height = btnEliminar.Height;
            smallPanel.Top = btnEliminar.Top;
            eliminar1.BringToFront();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            smallPanel.Height = btnConsultar.Height;
            smallPanel.Top = btnConsultar.Top;
            consultar1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion conx = new conexion();
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
